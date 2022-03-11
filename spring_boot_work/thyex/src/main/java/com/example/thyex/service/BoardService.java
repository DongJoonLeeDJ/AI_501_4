package com.example.thyex.service;

import com.example.thyex.dto.BoardTailFormDto;
import com.example.thyex.entity.Board;
import com.example.thyex.entity.BoardTail;
import com.example.thyex.repository.BoardRepository;
import com.example.thyex.repository.BoardTailRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class BoardService {

    @Autowired
    BoardRepository boardRepository;

    @Autowired
    BoardTailRepository boardTailRepository;

    public void save(BoardTailFormDto boardTailFormDto) throws Exception{
        Board board =
                boardRepository.findById(
                        boardTailFormDto.getBoard_id())
                        .orElseThrow(Exception::new);

        BoardTail boardTail = BoardTail.createBoardTail(boardTailFormDto,board);
        boardTailRepository.save(boardTail);
    }

}
