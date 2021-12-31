<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.board.BoardDao" %>
<%@ page import="com.example._1224.board.BoardDto" %>
<html>
<head>
    <title>Title</title>
    <jsp:include page="../head.jsp"/>
    <%
        int idx = Integer.parseInt(request.getParameter("idx"));
        BoardDao bd = new BoardDao();
        BoardDto row = bd.selectrow(idx);
    %>
</head>
<body>
    <jsp:include page="../nav.jsp"/>
    <div class="container">
        <h2>boardview</h2>
        <div style="border: 1px solid #ccc;
                    border-radius: 3%;
                    padding: 0.5rem;">
            <div class="form-group">
                <label>title</label>
                <strong><%=row.getTitle()%></strong>
                <label>name</label>
                <strong><%=row.getName()%></strong>
            </div>
            <hr>
            <div class="form-group">
                <label>content</label>
                <div>
                <%=row.getContent()%>
                </div>
            </div>
            <hr>
            <div class="form-group">
                <label>작성일자</label>
                <div>
                    <%=row.getWdate()%>
                </div>
            </div>
        </div>
        <button type="button" class="btn btn-primary">수정</button>
        <button type="button" class="btn btn-primary">삭제</button>
    </div>
</body>
</html>
