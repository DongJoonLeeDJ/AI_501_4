package com.example.thyex.dto;

import lombok.*;

import javax.validation.constraints.NotEmpty;

@Getter
@Setter
@ToString
@AllArgsConstructor
@RequiredArgsConstructor
public class MemberFormDto {

    @NotEmpty
    private String email;

    @NotEmpty
    private String pwd;
}
