<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>책 목록</title>
</head>
<body>
	<h1>책 목록</h1>
	

	<form> <!-- 아무것도 안 넣음. 어차피 자기 자신으로 그대로 올거니까. GET방식으로 넘어옴-->
	<!-- placeholder input태그에 기본으로 연하게 적힌 값 -->
		<input type="text" placeholder="검색" name="keyword" value="${keyword}"/>
		<input type="submit" value="검색"/>
	</form>

	
	
	<table>
		<thead>
			<tr>
				<td>제목</td>
				<td>카테고리</td>
				<td>가격</td>
			</tr>
		</thead>
		<tbody> <!-- data라는 키는 list를 가지고 있고, row는 이 리스트 안에 있는 값들 하나 하나 이다. -->
			<c:forEach var="row" items="${data}">
				<tr>
					<td>${row.title}</td>
					<td>${row.category}</td>
					<td><fmt:formatNumber type="number" maxFractionDigits="3" value="${row.price}"/></td>
				</tr>
			</c:forEach>
		</tbody>
	</table>
	<p><a href="/create">생성</a></p>
</body>
</html>



