<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.member.MemberDto" %>
<%@ page import="com.example._1224.member.MemberDao" %>
<%
//    String email  = request.getParameter("email");
//
//    MemberDto dto = new MemberDto(email,pwd,)

    // 회원목록 회원가입 회원수정 회원삭제
    // 게시판목록 글작성 글수정 글삭제
    // 방명록목록 방명록작성 방명록수정 방명록삭제
    // spring...으로 진행
%>

<jsp:useBean id="dto" class="com.example._1224.member.MemberDto">
</jsp:useBean>
<jsp:setProperty name="dto" property="*"></jsp:setProperty>
<%=dto%>
<%
    // db 저장 로직...
    MemberDao dao = new MemberDao();
    dao.memberset(dto);

    response.sendRedirect("/1224_war_exploded/index.jsp");
    // 할 수 있다.!!! 모든 사람이 할수 있다.!!
%>