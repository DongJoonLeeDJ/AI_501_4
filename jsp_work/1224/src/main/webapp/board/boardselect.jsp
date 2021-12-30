<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-30
  Time: 오전 9:34
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%
    BoardDao bd = new BoardDao();
    List<BoardDto> list = db.boardSelect();
%>
<html>
<head>
    <title>Title</title>
    <jsp:include page="../head.jsp"/>
</head>
<body>
    <jsp:include page="../nav.jsp"/>
    <div class="container">
        <h2>boardselect</h2>
    </div>
</body>
</html>
