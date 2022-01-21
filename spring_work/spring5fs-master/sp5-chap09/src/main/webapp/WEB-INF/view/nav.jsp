<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
    <!-- Brand -->
    <a class="navbar-brand" href="/sp5-chap09/">Logo</a>

    <!-- Links -->
    <ul class="navbar-nav">
        <li class="nav-item">
            <a class="nav-link" href="/sp5-chap09/member/selectall">memberlist</a>
        </li>
        <li class="nav-item">
            <a class="nav-link" href="/sp5-chap09/member/insertform">memberform</a>
        </li>
        <!-- Dropdown -->
        <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">
                Todo
            </a>
            <div class="dropdown-menu">
                <a class="dropdown-item" href="/sp5-chap09/todo/selectall">selectall</a>
                <a class="dropdown-item" href="/1224_war_exploded/board/boardinsertform.jsp">insert</a>
                <a class="dropdown-item" href="#">Link 3</a>
            </div>
        </li>
        <!-- Dropdown -->
        <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">
                Board
            </a>
            <div class="dropdown-menu">
                <a class="dropdown-item" href="/1224_war_exploded/board/boardselect.jsp">select</a>
                <a class="dropdown-item" href="/1224_war_exploded/board/boardinsertform.jsp">insert</a>
                <a class="dropdown-item" href="#">Link 3</a>
            </div>
        </li>
        <li class="nav-item">
            <a class="nav-link" href="/1224_war_exploded/file/fileuploadform.jsp">fileupload</a>
        </li>
    </ul>
</nav>