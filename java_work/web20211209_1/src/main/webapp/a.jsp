<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%@ page import="aaa.AA" %>
<%
	AA aa = new AA();
	aa.doPrint();
	String gugu = aa.getGugudanString();
	
	// a.jsp -> a_jsp.java
	// �ܼ� ������... html ��������..
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
<% out.println(gugu); %>
</body>
</html>