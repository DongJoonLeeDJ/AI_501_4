<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<%@ include file="../head.jsp"%>
</head>
<body>
<%@ include file="../nav.jsp"%>
<h1>todoselectall</h1>
${list}<br>
<c:forEach items="${list}" var="dto">
${dto.email}
</c:forEach>
<!-- for if switch set -->
</body>
</html>