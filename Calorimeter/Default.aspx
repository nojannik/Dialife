<%@ Page Title="" Language="C#" MasterPageFile="~/Them.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calorimeter.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<script>/* Firefox needs this to prevent FOUC. Wow. */</script>
<header>
<div class="container">
<div class="row">
<div class="twelve columns">
<ul>
<li><a href="Login.aspx">Login</a></li>
<li><a href="#about">About us</a></li>
    <li><a href="#aboutproj">About Project</a></li>
<li><a href="/Community" class="active">Community</a></li>
</ul>
</div>
</div>
<div class="row">
<div class="twelve columns">
<h1>- DiaLife -</h1>
<h4>A recommender system </h4>
<a href="Registration.aspx" class="btn">Register</a>
</div>
</div>
<section class="services" id="about">
<div class="row">
<div class="twelve columns">
<h3>Our Team</h3>
</div>
</div>
<div class="row">
<div class="one-half column">
<h4>Nojan Nikaeen</h4>
<p>Majoring in computer Science, a contributor in this project as database designer and programmer. Graduation expected this semester</p>

</div>
<div class="one-half column">
<h4>Archie Gamana</h4>
<p>Majoring in I.T. , a contributor in this project as Systems administrator and programmer. Graduation expected this semester</p>

</div>
</div>
<p></p>
<div class="row">
<div class="one-half column">
<h4>Christian Medina</h4>
<p>Majoring in Computer Science , a contributor in this project as Front-end designer and programmer. Graduation expected this semester.</p>

</div>
</div>
</section>
</div>
</header>


<section class="about"  id="aboutproj">
<div class="container">
<div class="row">
<div class="twelve columns">
<h3>About the project</h3>
</div>
</div>
<div class="row bottom">
<div class="two-thirds column">
<p>This recipe recommender system can provide recipes for the users based on their input needs, preferences, and varieties or even from the ingredients available in their kitchen the system will provide a recipe. This can help in choosing a right dish for the kind of meal. Some recipe recommender system are also being use to provide recipe for the better health of a person and some recipe recommender system are for diabetic patients which also proves to be useful for the diabetic persons providing significant changes to the way of living of some diabetic people. 
Hence, we proposed a web application were people with diabetes can browse for a healthy diet plan. 
    The recommender system will give a diet plan based on the user’s personality or daily needs. 
    The user can also customize the recipes that are given to them if they do not want the recipes in 
    the diet plan that will be first given by the system. The system will also provide some helpful
    recommendations from the user’s activity during the past few days. Lastly the user can check his or
    her profile which contains some of the basic requirements for having a healthy diabetic lifestyle. 
    In that note the motivation for this study is to make the life of the Filipino 
    Diabetic Society easier because of a diet plan that can help them have a nourishing life.</p>
</div>
<div class="one-third column">
<h4>Host</h4>
<ul>
<li>Google Cloud</li>
</ul>
<h4>Language</h4>
<ul>
<li>C Sharp</li>
</ul>
</div>
</div>
<div class="row">
<div class="twelve columns">
<h4 class="center">Share this page</h4>
</div>
</div>
<div class="row">
<div class="twelve columns">
<!-- AddToAny BEGIN -->
<div class="a2a_kit a2a_kit_size_32 a2a_default_style" data-a2a-url="http://35.194.229.199/" data-a2a-title="DiaLife">
<a class="a2a_dd" href="https://www.addtoany.com/share"></a>
<a class="a2a_button_facebook"></a>
<a class="a2a_button_twitter"></a>
<a class="a2a_button_email"></a>
<a class="a2a_button_facebook_messenger"></a>
<a class="a2a_button_reddit"></a>
</div>
<script async src="https://static.addtoany.com/menu/page.js"></script>
<!-- AddToAny END -->
</div>
</div>
</div>
</section>


<section class="contact">
<div class="container">
<div class="row">
<div class="twelve columns">
<h3>Contact</h3>
</div>
</div>
<div class="row">
<div class="offset-by-two eight columns">
</div>
</div>
<div class="row">
<div class="twelve columns">
<a href="mailto:nojannik@gmail.com" class="btn block btn-blue">Mail me</a>
</div>
</div>
</div>
</section>
    
</asp:Content>
