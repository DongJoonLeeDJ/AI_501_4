<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
${aa}
<form:form action="/sp5-chap11/member/insert" method="post" modelAttribute="memberForm">
	idx <form:input path="idx"/><br>
	email <form:input path="email"/><br>
	pwd <form:input path="pwd"/><br>
	gender <form:input path="gender"/><br>
	<input type="submit" value="insert하기"/>
</form:form>

</body>
</html>