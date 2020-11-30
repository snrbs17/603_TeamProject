# 603_TeamProject


![image](https://user-images.githubusercontent.com/74403767/100558802-31dde700-32f3-11eb-9f6a-27ed10602deb.png)

데이터 그리드 뷰에 데이터가 입력되지 않는 문제

======================================================================

Csharp Sturdy 페이지(URL : http://www.csharpstudy.com/WinForms/WinForms-datagridview.aspx)를 참고해
테이블에 바인딩할 데이터셋이 없다는 것을 알게 됨

![KakaoTalk_20201126_102214179](https://user-images.githubusercontent.com/74403767/100558945-e8da6280-32f3-11eb-8899-aef3fefb48f2.png)

Import class를 선언해 테이블에 바인딩

======================================================================

LINQ 쿼리식으로 data를 가져오니 매 버튼마다 쿼리문을 각각 가지고 있어야 하는 문제 발생
=> 메소드식으로 바꾼 후 각 버튼이 전체 LINQ의 한 줄만을 담당하도록 변경해야 함

======================================================================

![KakaoTalk_20201126_164133002](https://user-images.githubusercontent.com/74403767/100559091-85046980-32f4-11eb-91bc-8018a51ed798.png)

메소드식으로 변경 후 람다식을 메소드로 빼서 정리함

======================================================================

![image](https://user-images.githubusercontent.com/74403767/100559212-fe03c100-32f4-11eb-90e6-0ac1d25e4fb8.png)

StorageType으로 데이터를 한차례 더 분류할 수 있도록 변경함


========================================================================
========================================================================


![초기](https://user-images.githubusercontent.com/74527111/100558573-508fae00-32f2-11eb-8dbe-0995a6825640.GIF)
![일반선택](https://user-images.githubusercontent.com/74527111/100558576-54bbcb80-32f2-11eb-916e-49a954fb8c1c.GIF)
![토글사용](https://user-images.githubusercontent.com/74527111/100558577-55ecf880-32f2-11eb-9ee9-91a8a0ad4dfb.GIF)
![선택취소](https://user-images.githubusercontent.com/74527111/100558580-584f5280-32f2-11eb-8c03-9b2a50ac16dd.GIF)

=========================================================================


![원상복귀](https://user-images.githubusercontent.com/74527111/100558620-80d74c80-32f2-11eb-95ba-5bc84c5f11c5.GIF)
![수정후선택](https://user-images.githubusercontent.com/74527111/100558626-892f8780-32f2-11eb-9845-da53587ac655.GIF)
![수정후복귀](https://user-images.githubusercontent.com/74527111/100558627-8b91e180-32f2-11eb-973d-7481b85843d9.GIF)



일반 보관함에서 보관함을 선택 후 토글로 넘어간 뒤에 선택 취소하면 분류가 다르기때문에 선택이 불가한
회색으로 나타나야했지만 보관함 선택이 가능한 흰색 상태로 나타났고 반대의 경우도 마찬가지였다.

toggleFlag로 현재 화면에서 토글이 나타내고 있는 정보를 받았고
그 정보에 맞게 보관함의 번호를 구분하여 일반과 신선을 나눠서 수정하였다



