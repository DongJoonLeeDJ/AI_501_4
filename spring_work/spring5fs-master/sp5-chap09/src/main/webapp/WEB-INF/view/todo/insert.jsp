<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form"%>
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
		position: relative;
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
	.todiv{
		position: absolute;
		top: 30px;
		right: 10px;
	}
</style>
<script type="text/javascript">
	$('document').ready(function(){ 
		$('#listbtn').on('click',function(){ 
			window.location='selectall';
		});
	})
</script>
</head>
<body>
<%@ include file="../nav.jsp"%>
<form:form action="insert" method="post" modelAttribute="tododto">
	<div class="container mycolor">
		<h1>todoinsert</h1>
		<div class="todiv">
			<button id="listbtn" class="btn btn-primary">목록</button>
			<input type="submit" class="btn btn-primary" value="저장"/>
		</div>
		<div class="wrap">
			할일 
			<form:textarea class="form-control" path="todo"/>			
		</div>
	</div>
</form:form>
</body>
</html>



















