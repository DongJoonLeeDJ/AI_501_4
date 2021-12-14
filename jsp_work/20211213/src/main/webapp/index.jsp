<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<%@ page import="com.kb.m1213.AA" %>
<%@ page errorPage="error.jsp"%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<c:set var="a" value="123"/>
${a}
<c:out value="${a}"/>
<%

    AA aa = new AA();
    aa.doA();
    int retvalue = aa.doB();
    out.print(retvalue);

    int a = 10;
    int b = 0;
//    System.out.println(a/b);
%>
<%=retvalue%>
<!DOCTYPE html>
<html>
<head>
    <title>JSP - Hello World</title>
</head>
<body>
<%@include file="top.jsp"%>
<h1><%= "Hello World!" %>
</h1>
<br/>
<a href="hello-servlet">Hello Servlet</a>
<%@include file="foot.jsp"%>
</body>
</html>