

<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example._1224.board.BoardDao" %>
<%@ page import="com.example._1224.board.BoardDto" %>
<%
    // 주소줄에 있는 idx 값 가져오기
    int idx = Integer.parseInt(request.getParameter("idx"));
    // 데이터베이스 액세스 객체 생성
    BoardDao dao = new BoardDao();
    // 엑세스 객체를 통해서 idx 번호 행 가져와서 dto에 담는거죠...
    BoardDto dto = dao.selectrow(idx);
%>
<html>
<head>
    <title>Title</title>
    <jsp:include page="../head.jsp"/>
    <script>
        function chk(){
            var title = $('#title').val();
            var name = $('#name').val();
            var content = $('#content').val();
            if(!title)
                alert('제목을 입력하세요');
            else if(!name)
                alert('작성자을 입력하세요');
            else if(!content)
                alert('내용을 입력하세요');
            else
                return true;
            return false;
        }
    </script>
</head>
<body>
    <jsp:include page="../nav.jsp"/>
    <div class="container">
        <h2>boardupdate</h2>
        <form action="boardupdateproc.jsp" onsubmit="return chk()">
            <input type="hidden" name="idx" value="<%=dto.getIdx()%>">
            <div class="form-group">
                <label for="title">title</label>
                <input type="text"
                       class="form-control"
                       id="title"
                       name="title"
                       style="width: 70%;"
                       value="<%=dto.getTitle()%>"
                >
                <label for="name">name</label>
                <input type="text" class="form-control" id="name" name="name"
                       value="<%=dto.getName()%>"
                       style="width: 25%;">
            </div>
            <div class="form-group">
                <label for="content">content</label>
                <textarea rows="7" class="form-control" id="content" name="content"><%=dto.getContent()%></textarea>
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>
    </div>
</body>
</html>
