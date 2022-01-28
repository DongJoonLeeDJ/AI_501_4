<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>

<%@page import="chap09.member.MemberDto"%>
<%@page import="java.util.List"%>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<%@ include file="../head.jsp"%>
</head>
<body>
<%@ include file="../nav.jsp"%>
<h1>selectall</h1>
소스를 바꿔면 되나...
<%=request.getAttribute("list")%>
<% 
	List<MemberDto> list = 
		(List<MemberDto>) request.getAttribute("list");
	for(MemberDto dto : list){
		out.print(dto.getEmail());
		out.print(dto.getGender());
	}
%>
<br>
${list}<br>
<c:forEach items="${list}" var="dto">
${dto.email}
</c:forEach>
</body>
</html>