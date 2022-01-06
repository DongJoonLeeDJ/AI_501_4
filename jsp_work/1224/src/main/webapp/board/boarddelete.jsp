<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.board.BoardDao" %>
<%
    int idx = Integer.parseInt(request.getParameter("idx"));
    BoardDao dao = new BoardDao();
    boolean ret = dao.delete(idx);
    if(ret){
        out.println("삭제되었습니다.");
    }else{
        out.println("실패했습니다.");
    }

%>