<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<%@ include file="head.jsp"%>
</head>
<body>
<%@ include file="nav.jsp"%>
<hr>
<div class="container">
	<div class="row">
		<div class="col-sm-3">
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