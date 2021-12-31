<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.board.BoardDao" %>
<%@ page import="com.example._1224.board.BoardDto" %>
<%@ page import="java.util.List" %>
<%
    BoardDao bd = new BoardDao();
    List<BoardDto> list = bd.selectlist();
%>
<html>
<head>
    <title>Title</title>
    <jsp:include page="../head.jsp"/>
</head>
<body>
    <jsp:include page="../nav.jsp"/>
    <div class="container">
        <h2>boardinsert</h2>
        <form action="boardinsertproc.jsp">
            <div class="form-group">
                <label for="title">title</label>
                <input type="email" class="form-control" id="title" name="title" style="width: 70%;">
                <label for="name">name</label>
                <input type="text" class="form-control" id="name" name="name" style="width: 25%;">
            </div>
            <div class="form-group">
                <textarea rows="7" class="form-control" name="content"></textarea>
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>
    </div>
</body>
</html>
