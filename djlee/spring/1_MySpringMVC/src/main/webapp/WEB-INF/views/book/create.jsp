<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>책 생성하기</title>
</head>
<body>

<!-- 태그 적는 방식 2가지. -->
<!-- 1. 보통 태그는 여는 태그와 닫는 태그로 구성되는 데, 여는 태그와 닫는 태그가 반드시 다 있어야 할 경우 <h1></h1> -->
<!-- 2. <img> 태그 처럼 닫는 태그가 없을 때, <img/> 이렇게 표기하기 함 -->
<!-- 3. <img>처럼 쓰는 건 HTML표기법. <img/>처럼 쓰는 건 xhtml 표기법 -->
<!-- action 속성 생략되면 자기 자신으로 오는 것. 즉 submit 누르면 자기 자신으로 오되, POST방식으로 온다. -->
	<h1>책 생성하기</h1>
	<form method="POST">
		<p>제목 : <input type="text" name="title"></p>
		<p>카테고리 : <input type="text" name="category"></p>
		<p>가격 : <input type="text" name="price"></p>
		<p><input type="submit" value="저장"></p>
		
	</form>

</body>
</html>