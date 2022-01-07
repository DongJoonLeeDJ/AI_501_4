<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2022-01-07
  Time: 오전 10:42
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%
    Cookie[] coks = request.getCookies();

    for(Cookie co: coks){
        out.println(co.getName());
        out.println("&nbsp;=&nbsp;");
        out.println(co.getValue());
        out.println("<br>");
    }
%>