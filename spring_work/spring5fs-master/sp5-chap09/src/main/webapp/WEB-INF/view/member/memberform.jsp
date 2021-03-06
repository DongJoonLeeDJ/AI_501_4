<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<%@ include file="../head.jsp"%>
<script type="text/javascript">
	$('document').ready(function() {
	});
</script>
</head>
<body>
	<%@ include file="../nav.jsp"%>
	<div class="container">
		<h1>memberform</h1>
		<form:form action="memberinsert" method="post" modelAttribute="memberdto">
			<form:hidden path="idx"/>
			<div class="form-group">
				<label for="email">Email address:</label> 
				<form:input 
					path="email"
					type="email"
					class="form-control" 
					placeholder="Enter email" 
					/>
			</div>
			<div class="form-group">
				<label for="pwd">Password:</label> 
				<form:input 
					path="pwd"
					type="password"
					class="form-control"
					placeholder="Enter password" 
					/>
			</div>
			<button type="submit" class="btn btn-primary">Submit</button>
		</form:form>
	</div>
</body>
</html>