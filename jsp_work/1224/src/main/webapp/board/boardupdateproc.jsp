<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.board.BoardDao" %>
<%@ page import="com.example._1224.board.BoardDto" %>
<%@ page import="java.util.List" %>

<jsp:useBean id="dto" class="com.example._1224.board.BoardDto"></jsp:useBean>
<jsp:setProperty name="dto" property="*"></jsp:setProperty>
<%
//    BoardDto dto = new BoardDto();
//    dto.setContent(request.getParameter("content"));
//    dto.setTitle(request.getParameter("title"));
//    dto.setName(request.getParameter("name"));

    BoardDao bd = new BoardDao();
    boolean ret = bd.update(dto);
    if(ret == true)
        response.sendRedirect("boardselect.jsp");
    else {
%>
<%=ret%>가 나와서 update 실패!!
<%
    }
%>

