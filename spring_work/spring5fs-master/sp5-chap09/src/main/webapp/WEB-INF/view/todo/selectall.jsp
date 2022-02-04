<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<%@ include file="../head.jsp"%>
<link href="../mycss.css">
<link href="https://fonts.googleapis.com/css?family=Gamja+Flower:400" rel="stylesheet">
<link href="https://fonts.googleapis.com/css?family=Gugi:400" rel="stylesheet">
<style type="text/css">
	div{
		font-family: Gugi;
	}
	.mycolor{
		background-color: #bbb;
		padding: 20px;
	}
	.wrap{
		display: flex; 
        flex-direction: column;
		align-items: center;
	}
	.box{
		position: relative;
		margin: 10px;
		width: 300px;
		height: 100px;
		border-radius: 10px 5px 10px 5px;
		border: 1px solid #aaa;
		text-align: center;	
	}
	.trash{
		position: absolute;
		bottom: 0;
		right: 0;
	}
</style>
</head>
<body>
<%@ include file="../nav.jsp"%>
<div class="container mycolor">
	<h1>todolist</h1>
	<div style="float: right;">
		<button class="btn btn-primary">할일추가</button>
	</div>
	<div class="wrap">
		<c:forEach items="${list}" var="dto">
			<div class="box">
				<span>${dto.todo}</span>
				<div class="trash">
					<button class="btn btn-primary">휴지통</button>
				</div>
			</div>
		</c:forEach>
	</div>
</div>
</body>
</html>



















