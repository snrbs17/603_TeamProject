# The보관함(v1.0.0) : 물품 관리 프로그램

# 개요

- XX에서 사용하는 물품 보관 

# 개발 기간

- 2020년 11월 23일 ~ 2020년 11월 29일

# 기능 목록

## 물품 보관용 프로그램

### 1. 회원 가입 및 로그인

<img src="./Document/고객/1_기본정보_입력.jpg" width="45%">

- 회원 가입을 하면 ID 중복판단 후 Password가 맞으면 다음 창으로 넘어간다.
- ID와 Password 확인 후 로그인.

### 3. 선택 (입고, 출고, 검색)

<img src="./Document/고객/3_진료과_선택.jpg" width="45%">

- 원하는 항목을 선택한다.

### 3-1. 입고 선택

<div>
<img src="./Document/고객/4_문진표_작성.jpg" width="45%">
<img src="./Document/고객/4-1_문진표_작성_하단부.jpg" width="45%">
</div>

- 입고 선택시 일반/신선에 따라 다른 보관함을 지정하여 사용한다.
- 보관함을 선택하고 시간을 지정한 뒤 결제를 한다.

### 3-2. 출고 선택

- 원하는 보관함을 선택하고 출고한다.
- 출고 시 시간이 지났다면 추과금이 부여된다.

### 3-3. 검색 선택

- 현재 사용중인 보관함을 확인한다.
- 과거 데이터를 확인한다.



## 관리자용 프로그램

### 1. 직원 로그인

<div>
<img src="./Document/직원/1_직원_로그인.jpg" width="45%">
<img src="./Document/직원/1-1_비밀번호_변경.jpg" width="45%">
</div>

- 확인 버튼을 누르면 정보가 입력되었는지 판단하고 다음 창으로 넘어간다.



# 관리 항목

### 1. 고객 정보

- ID와 Password를 확인할 수 있다.

### 2. 직원 정보

- 각 보관소의 직원을 확인할 수 있다.

### 3. 보관함 정보

- 현재 사용중인 정보와 과거 정보들을 확인할 수 있다.

### 4. 관리자용 정보

- 매출액같은 정보를 확인할 수 있다.



# 사용 기술

## 언어

- C# 8.0

## 프레임워크

- .Net FrameWork 4.8
- EntityFrameWork 6.4
- Winform

## 데이터베이스

* MSSQL Server 2019

## 기타 개발환경

- Windows 10
- Microsoft Visual Studio Community 2019 v16.8
- Microsoft SQL Server Management Studio v18.6

# 데이터베이스 스키마

![스키마](./Document/스키마.png)

- 모든 항목이 제 3 정규화까지 완료됐다

# 순서도

## 1. 고객용 프로그램

![고객용 다이어그램](./Document/고객알고리즘.jpg)

## 2. 직원용 프로그램

![직원용 다이어그램](./Document/직원알고리즘.jpg)

# Point of Interest

# DB 테이블의 속성 변경 등 업데이트 내역이 EntityFramework에 반영되지 않은 문제 [#24](https://github.com/dlehd333/DKClinic/issues/24)

## 증상
- 문진표 저장을 누를 시 에러 발생

## 원인
- EntityFramework로 불러온 데이터베이스의 문진표 테이블 PK컬럼의 IDENTITY_INSERT 속성이 OFF로 되어있었다

## 결과
- 처음에는 DB에 있는 문진표 테이블 PK컬럼의 IDENTITY_INSERT 속성을 ON으로 변경했다. 하지만 같은 오류가 발생했다.
- 확인 결과, 처음에 DB 스키마 설계 시 테이블 PK에 IDENTITY_INSERT 속성을 ON으로 바꾸지 않았고, 그 상태로 EntityFramework로 불러와, EntityFramework상에는 IDENTITY_INSERT 속성이 OFF로 저장되어 있었다.
- 그래서, EntityFramework 다이어그램에서 우클릭으로 제공하는 '데이터베이스에서 모델 업데이트'메뉴를 실행, 업데이트 마법사를 이용해 DB의 정보를 업데이트하여 문제를 해결함
![update](https://user-images.githubusercontent.com/69996028/100321023-6b69d600-3005-11eb-8bb2-52bb1a5326c3.png)

---

# 외래키로 연결된 여러 테이블의 값을 동시에 삽입하는 트랜잭션 진행중에 에러가 발생하는 문제 [#24](https://github.com/dlehd333/DKClinic/issues/24)

## 증상
- 새로운 Customer(환자)가 문진표를 입력하면, 에러가 발생

## 원인
- 신규 환자가 문진표 입력이 완료되면 Customer(고객), Questionnare(문진표), Response(문진표응답) 총 3개의 테이블에 데이터가 삽입되는데, 이 때 신규 환자는 등록 전에는 CustomerID가 없어, Customer테이블에서 키값의 최대값을 가져와 등록했는데 이 값이 실제 IDENTITY 컬럼을 통해 저장되는 내용과 맞지 않아 오류가 발생했다
- 여러 테이블의 데이터가 동시에 저장되는 트랜잭션을 끊지 않고 IDENTITY 컬럼의 값을 미리 구해서 저장하거나 다른 방법이 필요했다.

## 결과
- 처음에는 C#에서 IDENTITY 컬럼의 값을 구하는 법을 찾고 있었는데, 검색 하던 도중 다른 방법을 발견했다
- EF가 ID값을 찾아 할당하는 것이 아니라 테이블 개체 자체를 할당하는 기능을 지원하며, EF로 생성된 Entity 모델에 생성되어 있는 외래키로 연결된 하위 모델을 이용해 연결할 수 있다는 것을 알게 되었다.
- 그래서 Entity 모델의 개체를 생성할 때 상위 테이블 개체를 연결해주면, 한번에 SaveChange를 진행해도 Insert된 개체에 대해 자동으로 ID키가 연결되어 에러가 발생하지 않고 트랜젝션도 깨지지 않게 된다.
- 그래서 개체를 생성할 때, 상위 테이블 개체를 연결해주는 작업을 진행했다.

```csharp
public Questionnare CreateQuestionnare { get; set; }

// before
CreateQuestionnare = new Questionnare();
// after
CreatedQuestionnare = new Questionnare { Customer = ConnectedCustomer };
```

---

