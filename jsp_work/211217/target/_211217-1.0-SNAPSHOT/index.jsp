<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>JSP - Hello World</title>
</head>
<body>
<h1><%= "Hello World!" %>
</h1>
<br/>
<a href="hello-servlet">Hello Servlet</a>
<form action="gugudan.jsp" method="post">
    구구단 <input type="text" name="gugudan"><br>
    aaa <input type="text" name="aaa"><br>
    <input type="submit" value="전송">
</form>
<h1>reqeust사용해보기</h1>
<a href="request_befo.jsp">request_befo</a>
<h1>response사용해보기</h1>
<a href="response.jsp?send=true">바로돌아오기</a><br>
<a href="response.jsp?send=false">가보기</a>
<h1>session사용해보기</h1>
<a href="sessionset.jsp">세션지정하기</a><br>
<a href="sessionget.jsp">세션값확인하기</a>

<!--
    pyqt 이미 했는거
    1개 + 3개 + 각종자격증... = 이력서.. 쓰고..

    3월중순..수료까지..

    박명회쌤이랑 2개의 프로젝트..
    jsp spring 으로 웹프로젝트...
    python.. 머신러닝 딥러닝.. -> 프로젝트
    티셔츠 이미지를 넣었따.. 티셔츠..
    바지 이미지를 넣었다.. 바지..

    이동준썜이 C#
    윈도우앱프로젝트...

    php언어... ios swift .. android...
    vue.js react.js
    라즈베리아두... 아두이노..
-->
</body>
</html>