<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<%@ include file="../head.jsp"%>
<script type="text/javascript">
	$('document').ready(function(){
		var myfn = ()=>{ alert('누름') };
		var mya = function(){  alert('누름') };
// 		$('#memberform').on('click', function(){ alert('누름')} );
		$('#memberform').on('click', ()=>{ 
			window.location='memberform';
		} );
	});
</script>
</head>
<body>
<%@ include file="../nav.jsp"%>
<div class="container">
<h1>memberselectall</h1>
<button class="btn btn-primary mt-3 mb-3" type="button">삭제</button>
<button class="btn btn-primary mt-3 mb-3" type="button" id="memberform">회원작성</button>
<table class="table">
	<tr>
		<th></th>
		<th>idx</th>
		<th>email</th>
		<th>pwd</th>
		<th>gender</th>
		<th>wdate</th>
	</tr>
	<c:forEach items="${list}" var="dto">
		<tr>
			<td><input type="checkbox"></td>
			<td>${dto.idx}</td>
			<td><a href="memberform?idx=${dto.idx}">${dto.email}</a></td>
			<td>${dto.pwd}</td>
			<td>${dto.gender}</td>
			<td>${dto.wdate}</td>
		</tr>
	</c:forEach>
</table>
<br>
</div>
</body>
</html>