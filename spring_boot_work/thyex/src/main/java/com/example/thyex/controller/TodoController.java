package com.example.thyex.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("todo")
public class TodoController {

    @GetMapping("selectall")
    public String selectall(){

        return "todo/selectall";
    }
}
