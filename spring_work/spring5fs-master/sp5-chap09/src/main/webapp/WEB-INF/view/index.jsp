<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<%@ include file="head.jsp"%>
<script type="text/javascript">
	$('document').ready(function(){
		$('#logout').on('click',function(){
// 			var resu = confirm('로그아웃하시겠습니까?');
// 			if(resu)
			window.location='logout';
		})
	})
</script>
</head>
<body>
<%@ include file="nav.jsp"%>
<hr>
<% 
// 	Object dto = session.getAttribute("login");
// 	out.print(dto);
%>
<div class="container">
	<div class="row">
		<div class="col-sm-3">
			<c:if test="${empty sessionScope.login }">
				<form action="login" method="post">
				<div class="form-group">
					<label for="email">Email address:</label>
					<input name="email" type="email" class="form-control" placeholder="Enter email" id="email">
				</div>
				<div class="form-group">
					<label for="pwd">Password:</label> 
					<input name="pwd" type="password" class="form-control" placeholder="Enter password" id="pwd">
				</div>
				<div class="form-group form-check">
					<label class="form-check-label"> 
						<input name="save" class="form-check-input" type="checkbox"> 
							Remember me
					</label>
				</div>
				<button type="submit" class="btn btn-primary">Submit</button>
			</form>
			</c:if> 
			<c:if test="${not empty sessionScope.login }">
				${sessionScope.login.email} 님 login 하심....
				<button class="btn btn-primary" id="logout">로그아웃</button>
			</c:if>
		</div>
		<div class="col-sm-9">
			<img src="https://dullyshin.github.io/images/logo.png"/>
		</div>
	</div>
	<hr>
	<div class="justify-content-center mb-3" style="text-align: center;">
		copy right 
	</div>
</div>
</body>
</html>