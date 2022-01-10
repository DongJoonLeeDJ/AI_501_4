<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.board.BoardDao" %>
<%@ page import="com.example._1224.board.BoardDto" %>
<%@ page import="java.util.List" %>
<%
    // 아무페이지 없이 올때도 pageNumber 1
    // 1page 누를때도 pageNumber 1
    int pagenum=1;
    Object pageNumber = request.getParameter("pageNumber");
    if(pageNumber != null){
        pagenum = Integer.parseInt((String)pageNumber);
    }
//    out.print(pagenum);
    BoardDao bd = new BoardDao();
    List<BoardDto> list = bd.selectlist(pagenum);
    System.out.println(list);

    // 총 페이지 개수 가져오기...
    int pagecnt = bd.selectpagecnt();
//    out.println(pagecnt);
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
                        <td><a href="boardview.jsp?idx=<%=dto.getIdx()%>"><%=dto.getTitle()%></a></td>
                        <td><%=dto.getWdate()%></td>
                    </tr>
                <%
                    }
                %>
            </tbody>
        </table>
        <ul class="pagination justify-content-center">
            <li class="page-item <%=pagenum==1?"disabled":""%>"><a class="page-link" href="boardselect.jsp?pageNumber=<%=(pagenum-1)%>">Previous</a></li>
            <%
            // i = 1 ,2 pagecnt = 2
            for ( int i= 1; i <= pagecnt;i++) {
            %>
                <li class="page-item <%=pagenum==i?"active":""%>">
                    <a class="page-link" href="boardselect.jsp?pageNumber=<%=i%>"><%=i%></a>
                </li>
            <%
            }
            %>
            <li class="page-item <%=pagenum==pagecnt?"disabled":""%>"><a class="page-link" href="boardselect.jsp?pageNumber=<%=(pagenum+1)%>">Next</a></li>
        </ul>
    </div>
</body>
</html>
