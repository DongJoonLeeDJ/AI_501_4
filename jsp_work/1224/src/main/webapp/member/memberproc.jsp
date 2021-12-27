<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.member.MemberDao" %>

<jsp:useBean id="dto" class="com.example._1224.member.MemberDto">
</jsp:useBean>
<jsp:setProperty name="dto" property="*"></jsp:setProperty>
<%=dto%>
<%
    // db 저장 로직...
    MemberDao dao = new MemberDao();
    dao.memberset(dto);

    response.sendRedirect("/1224_war_exploded/index.jsp");
%>