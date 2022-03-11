package com.example.thyex.controller;

import com.example.thyex.dto.BoardTailFormDto;
import com.example.thyex.entity.Board;
import com.example.thyex.entity.BoardTail;
import com.example.thyex.repository.BoardRepository;
import com.example.thyex.service.BoardService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import javax.validation.Valid;

@RequestMapping("boardtail")
@Controller
public class BoardTailController {

    @Autowired
    BoardService boardService;

    @Autowired
    BoardRepository boardRepository;

    @PostMapping("insert")
    public String intsert(@Valid BoardTailFormDto boardTailFormDto,
                          BindingResult bindingResult,
                          Model model){
        if(bindingResult.hasErrors()){
            model.addAttribute("board",boardRepository.findById(boardTailFormDto.getBoard_id())
                    .orElse(new Board()));
            return "board/view";
        }

        try {
            boardService.save(boardTailFormDto);
        } catch (Exception e) {
            System.out.println("Board id 가 참조 실패");
            model.addAttribute("board",boardRepository.findById(boardTailFormDto.getBoard_id())
                    .orElse(new Board()));
            return "board/view";
        }

        return "redirect:/board/view?id="+boardTailFormDto.getBoard_id();
    }
}

