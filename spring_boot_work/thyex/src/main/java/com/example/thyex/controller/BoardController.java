package com.example.thyex.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@RequestMapping("board")
@Controller
public class BoardController {

    @GetMapping("selectall")
    public String selectAll(){

        return "board/selectall";
    }

}
