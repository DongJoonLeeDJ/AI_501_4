package com.example.thyex.dto;

import lombok.*;

@Getter
@Setter
@ToString
@AllArgsConstructor
@RequiredArgsConstructor
public class MemberFormDto {
    private String email;
    private String pwd;
}
