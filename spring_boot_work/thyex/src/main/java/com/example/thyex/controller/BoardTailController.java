package com.example.thyex.controller;

import com.example.thyex.dto.BoardTailFormDto;
import com.example.thyex.entity.Board;
import com.example.thyex.entity.BoardTail;
import com.example.thyex.repository.BoardRepository;
import com.example.thyex.repository.BoardTailRepository;
import com.example.thyex.service.BoardService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

import javax.validation.Valid;
import java.util.HashMap;
import java.util.Map;

@RequestMapping("boardtail")
@Controller
public class BoardTailController {

    @Autowired
    BoardService boardService;

    @Autowired
    BoardTailRepository boardTailRepository;

    @Autowired
    BoardRepository boardRepository;

    @PostMapping("insert")
    public String intsert(@Valid BoardTailFormDto boardTailFormDto,
                          BindingResult bindingResult,
                          Model model){
        Board board = boardRepository.findById(boardTailFormDto.getBoard_id())
                .orElse(new Board());
        model.addAttribute("board",board);

//        model.addAttribute("boardTailFormDto",boardTailFormDto);

        if(bindingResult.hasErrors()){
            return "board/view";
        }

        try {
            boardService.save(boardTailFormDto);
            model.addAttribute("boardTailFormDto",new BoardTailFormDto());
        } catch (Exception e) {
            System.out.println("Board id 가 참조 실패");
            return "board/view";
        }

        return "redirect:/board/view?id="+board.getId();
    }

    // method get post put delete
    // @ResponseBody O -> String 문자열을 반환...
    // @ResponseBody X -> thymeleaf html 파일을 찾는다..
    @DeleteMapping("delete")
    @ResponseBody
    public Map<String,Object> delete(Long boardtail_id){
        Map<String,Object> map = new HashMap<>();
        try{
            boardTailRepository.deleteById(boardtail_id);
            map.put("code","ok");
        }catch (Exception e){
            map.put("code","fail");
        }
        return map;
    }
}

