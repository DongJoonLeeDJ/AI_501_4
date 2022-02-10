package com.example.restservice.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HelloController {

    @GetMapping("index")
    public String index(
            Model model,
            // http://localhost:8080/index?name=홍길동
            @RequestParam(required = false, defaultValue = "default", value = "name") String name
    ) {
        // ctrl alt l 자동정렬 단축키
        model.addAttribute("name", name);

        return "index";
    }
}
