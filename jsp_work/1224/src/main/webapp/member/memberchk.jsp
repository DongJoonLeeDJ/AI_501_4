<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.member.MemberDao" %>
<%
    String id = request.getParameter("id");
    MemberDao md = new MemberDao();
    String ret = md.memberchk(id);
//    out.println(id);

    if(ret.equals("true"))
        out.println("true");
    else
        out.println("false");
%>