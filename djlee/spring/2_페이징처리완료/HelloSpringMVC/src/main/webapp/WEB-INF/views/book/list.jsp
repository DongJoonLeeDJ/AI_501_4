<%@ page pageEncoding="UTF-8" contentType="text/html;charset=utf-8"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<html>
<head>
<title>책 목록</title>
<style>
	a {text-decoration: none}
</style>
</head>
<body>
	<h1>책 목록</h1>


	<!-- 	검색때문에 추가된 부분 -->
<!-- 검색창 영역을 추가한다. -->
<!-- <form 태그의 기본 HTTP 메소드는 GET이기 때문에 검색 버튼을 클릭하면 검색 파라미터가 있는 목록 페이지 /list?keyword=검색어로 이동한다. -->
	<form>
		<input type="text" placeholder="검색" name="keyword" value="${keyword}" />
<%-- 		<input type="text" placeholder="검색" name="keyword2" value="${keyword2}" /> --%>
		<input type="submit" value="검색" />
	</form>

	<!-- 	추가된 부분 -->

	<table>
		<thead>
			<tr>
				<td>제목</td>
				<td>카테고리</td>
				<td>가격</td>
			</tr>
		</thead>
		<tbody>
			<c:forEach var="row" items="${data}">
				<tr>
					<td><a href="/detail?bookId=${row.book_id}"> ${row.title}
					</a></td>
					<td>${row.category}</td>
					<td><fmt:formatNumber type="number" maxFractionDigits="3"
							value="${row.price}" /></td>
				</tr>
			</c:forEach>
		</tbody>
	</table>
	
	
	<c:if test="${startPage!=1}">
		<a href="/list?nowPage=${startPage-1}">&lt;</a>
	</c:if>
	
	<c:forEach var="idx" begin="${startPage}" end="${endPage}"> 
	
		<c:choose>
			<c:when test="${nowPage!=idx}">
				<a href="/list?nowPage=${idx}">${idx}&nbsp;</a>
			</c:when>
			<c:when test="${nowPage==idx}">
				<b>${idx}&nbsp;</b>
			</c:when>
		</c:choose>

	
	</c:forEach>
	<c:if test="${endPage!=totalcount}">
		<a href="/list?nowPage=${endPage+1}">&gt;</a>
	</c:if>
		 
	<p>
		<a href="/create">생성</a>
	</p>
</body>
</html>
