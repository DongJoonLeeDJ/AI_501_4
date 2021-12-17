<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-17
  Time: 오전 11:42
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
sessionset
setAttribute......getAttribute...
<%
    session.setAttribute("id","myid");
    out.println("세션지정했습니다.");
%>
<a href="index.jsp">메인페이지이동</a>
</body>
</html>
