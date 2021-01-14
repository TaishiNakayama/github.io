ul, ol, li,
h1, h2, h3, h4, h5, h6, p, div {
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Hiragino Kaku Gothic ProN W3', sans-serif;
}

li {
  list-style: none;
}

a {
  text-decoration: none;
}

/* ここからCSSを書いていきましょう */
header{
  background-color:rgba(34,49,52,0.9);
  height:65px;
  width:100%;
  position:fixed;
  Z-index:10;
}

.header-left{
  float:left;
}

.logo{
  width:124px;
  padding:20px 0px;
}

.header-right{
  float:right;
  background-color:rgba(255,255,255,0.3);
  line-height:65px;
  padding:0px 25px;
  color:white;
  cursor:pointer;
  transition:all 0.5s;
}

.header-right a{
  opacity:1;
  color:white;
  display:block;
}

.header-right:hover{
  background-color:rgba(255,255,255,0.5);
}

.container{
  width:1170px;
  margin:auto;
}

.top-wrapper{
  padding:180px 0px 100px 0px;
  text-align:center;
  color:white;
  background-image:url(https://prog-8.com/images/html/advanced/top.png);
  background-size:cover;
}

.top-wrapper h1{
  font-size:45px;
  font-weight:bold;
  letter-spacing:5px;
  opacity:0.7;
}

.top-wrapper p{
  opacity:0.7;
}

a{
  cursor:pointer;
}

.btn{
  color:white;
  opacity:0.8;
  padding:8px 24px;
  display:inline-block;
  border-radius:4px;
}

.signup{
  background-color:#239b76;
  margin-top:30px;
  margin-bottom:15px;
}

.top-wrapper p1{
  opacity:0.7px;
  margin-bottom:15px;
}

.facebook{
  background-color:#3b5998;
  margin:10px;
}

.twitter{
  background-color:#55acee;
}

.btn:hover{
  opacity:1;
}

.lesson-wrapper{
  height:580px;
  text-align:center;
  background-color:#f7f7f7;
}

h2{
  font-weight:normal;
  padding-top:80px;
  color:#5f5d60;
}

.lesson-wrapper h2{
  padding-bottom:50px;
}

.lesson{
  width:25%;
  float:left;
}

.lesson-icon{
  position:relative;
}

.lesson-icon p{
  color:white;
  position:absolute;
  top:90px;
  width:100%;
}

.text-contents{
  color:#b3aeb5;
  font-size:13px;
  display:inline-block;
  width:80%;
}

.messeage-wrapper{
  text-align:center;
  padding-bottom:80px;
}

.messeage-wrapper h2{
  color:#5f5d60;
}

.messeage-wrapper h3{
  padding-bottom:50px;
  color:#5f5d60;
}

.messeage {
  background-color:#5dca88;
  padding:15px 40px;
  cursor:pointer;
  box-shadow:0px 7px #1a7940;
}

.messeage:active{
  box-shadow:none;
  position:relative;
  top:7px;
}

footer{
  width:100%;
  padding:30px 0px;
  border-top: 1px solid #eee;
  float:left;
}

.footer-logo{
  width:124px;
}

footer p{
  font-size:12px;
  color:#b3aeb5;
}
