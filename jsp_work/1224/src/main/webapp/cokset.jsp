<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%
    Cookie coo1 = new Cookie("myname","javaking");
    Cookie coo2 = new Cookie("age","22");

    coo1.setMaxAge(60*1);
    coo2.setMaxAge(60*2);

    response.addCookie(coo1);
    response.addCookie(coo2);
%>
