package com.example.thyex.repository;

import com.example.thyex.entity.Board;
import org.springframework.data.jpa.repository.JpaRepository;

// insert, update, delete,select
public interface BoardRepository extends JpaRepository <Board,Long>{
}
