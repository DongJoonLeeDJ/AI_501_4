package com.example.thyex.controller;

import com.example.thyex.entity.Board;
import com.example.thyex.repository.BoardRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import java.util.List;

@RequestMapping("board")
@Controller
public class BoardController {

    @Autowired
    BoardRepository boardRepository;

    @GetMapping("selectall")
    public String selectAll(Model model){
        List<Board> list = boardRepository.findAll();
        model.addAttribute("list",list);
        return "board/selectall";
    }

    @GetMapping("insert")
    public String insert(){

        return "board/insert";
    }

}
