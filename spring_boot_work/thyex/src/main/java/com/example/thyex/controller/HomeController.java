package com.example.thyex.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class HomeController {

    @GetMapping("main")
    public String index(Model model){
        model.addAttribute("myname","honggildong");
        return "main";
    }
}
