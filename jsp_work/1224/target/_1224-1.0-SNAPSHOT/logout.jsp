<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%
    // session 내용 모두 지우기...
//  session.invalidate();

  // 한개만 지우기...
  session.removeAttribute("email");

    // index페이지 이동....
  response.sendRedirect("index.jsp");
%>
