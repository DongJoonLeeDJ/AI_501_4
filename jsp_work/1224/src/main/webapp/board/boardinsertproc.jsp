<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.board.BoardDao" %>
<%@ page import="com.example._1224.board.BoardDto" %>
<%@ page import="java.util.List" %>
<%
    BoardDao bd = new BoardDao();
    List<BoardDto> list = bd.selectlist();
    System.out.println(list);
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
        <table class="table">
            <thead>
                <tr>
                    <th>idx</th>
                    <th>작성자</th>
                    <th>제목</th>
                    <th>작성일자</th>
                </tr>
            </thead>
            <tbody>
                <%
                    for (BoardDto dto : list) {
                %>
                    <tr>
                        <td><%=dto.getIdx()%></td>
                        <td><%=dto.getName()%></td>
                        <td><%=dto.getTitle()%></td>
                        <td><%=dto.getWdate()%></td>
                    </tr>
                <%
                    }
                %>
            </tbody>
        </table>
    </div>
</body>
</html>
