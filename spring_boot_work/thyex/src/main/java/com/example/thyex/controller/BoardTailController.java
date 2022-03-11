package com.example.thyex.controller;

import com.example.thyex.dto.BoardTailFormDto;
import com.example.thyex.entity.BoardTail;
import com.example.thyex.service.BoardService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import javax.validation.Valid;

@RequestMapping("boardtail")
public class BoardTailController {

    @Autowired
    BoardService boardService;

    @PostMapping("insert")
    public String intsert(@Valid BoardTailFormDto boardTailFormDto,
                          BindingResult bindingResult,
                          Model model){
        if(bindingResult.hasErrors()){
            return "/board/view";
        }



        return "redirect:/board/view?id"+boardTail.getId();
    }
}

