
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.oreilly.servlet.MultipartRequest" %>
<%@ page import="com.oreilly.servlet.multipart.DefaultFileRenamePolicy" %>
<%
/*
    4가지만..
    request,response,out,session...
    내장객체...
    application..
 */
    String saveFolder = application.getRealPath("/fileupload");
    out.println(saveFolder);

    try{
        MultipartRequest multi =
                new MultipartRequest(
                        request,
                        saveFolder,
                        5*1024*1025,
                        "utf-8",
                        new DefaultFileRenamePolicy());

        String originalFileName = multi.getOriginalFileName("file1");
        String filename = multi.getFilesystemName("file1");

        String type = multi.getContentType("file1");
        out.println(originalFileName+"<br>");
        out.println(filename+"<br>");
        out.println(type+"<br>");

    }catch (Exception e){
        e.printStackTrace();
    }


%>