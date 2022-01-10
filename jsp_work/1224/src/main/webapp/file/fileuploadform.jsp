<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
    <%@ include file="../head.jsp"%>
</head>
<body>
<%@ include file="../nav.jsp"%>

<div class="container">
    <h1>파일업로드</h1>
    <form action="fileuploadproc.jsp"
          name="frm"
          method="post"
          enctype="multipart/form-data">
        aa = <input type="text" name="aa" class="form-control"><br>
        <input type="file" name="file1" class="btn btn-success">
        <input class="btn btn-primary" type="submit" value="upload">
    </form>
</div>

</body>
</html>
