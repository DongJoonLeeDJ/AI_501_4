<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String[] temp = request.getParameterValues("delidx");
    out.println(temp[0]);
    out.println(temp[1]);
    out.println(temp[2]);
%>
</body>
</html>
