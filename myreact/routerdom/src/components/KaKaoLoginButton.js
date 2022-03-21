import React from "react";
import { IconButton } from "@material-ui/core";
import { kakaoClientId, kakaoRedirectUri } from "../config/config";

const loginUri = `https://kauth.kakao.com/oauth/authorize?client_id=${kakaoClientId}\
&redirect_uri=${kakaoRedirectUri}&response_type=code`;

const KakaoLoginButton = () => {
  return (
    <IconButton>
      <a href={loginUri} rel="noopener noreferrer">
        <img src="/kakao_login_medium_narrow.png" />
      </a>
    </IconButton>
  );
};

export default KakaoLoginButton;