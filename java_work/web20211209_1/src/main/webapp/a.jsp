<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%@ page import="aaa.AA" %>
<%
	AA aa = new AA();
	aa.doPrint();
	String gugu = aa.getGugudanString();
	
	// a.jsp -> a_jsp.java
	// 能贾 备备窜... html 备备窜阑..
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