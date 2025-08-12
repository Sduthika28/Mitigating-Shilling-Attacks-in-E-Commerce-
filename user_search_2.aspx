<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="user_search_2.aspx.cs" Inherits="user_search_2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 150px;
        }
        .style2
        {
            text-align: left;
            width: 150px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="w3l-top-header">
        <div class="container-fluid">
            <div class="top-content-w3ls d-flex align-items-center justify-content-between">
                <div class="top-headers">
                    <ul>
                       
                    </ul>
                </div>
                <div class="top-headers top-headers-2">
                    <ul>
                        
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <!-- //top header -->
    <!--header-->
    <header id="site-header" class="fixed-top">
        <div class="container-fluid">
            <nav class="navbar navbar-expand-lg stroke">
                <h1>
                    <a class="navbar-brand d-flex align-items-center" href="#">
                        <img src="assets/images/logo.png" alt="" class="mr-1" />Shilling Attack</a>
                </h1>
                <!-- if logo is image enable this   
    <a class="navbar-brand" href="#index.html">
        <img src="image-path" alt="Your logo" title="Your logo" style="height:35px;" />
    </a> -->
                <button class="navbar-toggler  collapsed bg-gradient" type="button" data-toggle="collapse"
                    data-target="#navbarTogglerDemo02" aria-controls="navbarTogglerDemo02" aria-expanded="false"
                    aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon fa icon-expand fa-bars"></span>
                    <span class="navbar-toggler-icon fa icon-close fa-times"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarTogglerDemo02">
                    <ul class="navbar-nav ml-lg-auto">
                       <li class="nav-item ">
                            <a class="nav-link" href="user_home.aspx">Home <span class="sr-only">(current)</span></a>
                        </li>
                        <li class="nav-item active">
                            <a class="nav-link" href="user_search.aspx">Search</a>
                        </li>
                         <li class="nav-item ">
                            <a class="nav-link" href="user_purchased.aspx">Purchased</a>
                        </li>
                         <li class="nav-item ">
                            <a class="nav-link" href="user_query.aspx">Query</a>
                        </li>
                         <li class="nav-item ">
                            <a class="nav-link" href="user_status.aspx">Status</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="Default.aspx">Logout</a>
                        </li>
                        <!-- search button -->
                      
                        <!-- //search button -->
                    </ul>
                </div>
                <!-- toggle switch for light and dark theme -->
                <div class="cont-ser-position">
                    <nav class="navigation">
                        <div class="theme-switch-wrapper">
                            <label class="theme-switch" for="checkbox">
                                <input type="checkbox" id="checkbox">
                                <div class="mode-container">
                                    <i class="gg-sun"></i>
                                    <i class="gg-moon"></i>
                                </div>
                            </label>
                        </div>
                    </nav>
                </div>
                <!-- //toggle switch for light and dark theme -->
            </nav>
        </div>
    </header>
    <!--//header-->

    <!-- inner banner -->
    <div class="inner-banner">
        <section class="w3l-breadcrumb">
            <div class="container">
               
            </div>
        </section>
    </div>
    <!-- //inner banner -->

    <!-- about section -->
    <!-- //about section -->

    <!-- stats -->
  
    <!-- //stats -->

    <!-- about-bootom grids -->
    <!-- //bottom-grids-->

    <!-- team section -->
 
        <div class="container py-md-5 py-4">
            <div class="title-heading-w3 text-center mx-auto mb-5 pb-sm-4">
                <h3 class="title-main">Search Product</h3>
            </div>            
        </div>
      <!-- //team setion -->

                     <table align="center">
                      
                        <tr class="style3">
                             
                            <td class="style2">
			
			   <table align="center" class="style1">
              <tr>
                  <td class="style5">
                      </td>
                  <td class="style6">
                      Product Id</td>
                  <td class="style6">
                      <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                      &nbsp;&nbsp;</td>
              </tr>
              
              <tr>
                  <td class="style6">
                      </td>
                  <td class="style6">
                      Product Name</td>
                  <td class="style6">
                          <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
				  </td>
              </tr>
             
              <tr>
                  <td class="style7">
                      </td>
                  <td class="style7">
                      Price</td>
                  <td class="style7">
                      <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                  </td>
              </tr>
             
              <tr>
                  <td class="style8">
                      </td>
                  <td class="style8">
                      Description</td>
                  <td class="style8">
                      <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                  </td>
              </tr>
             
              <tr>
                  <td class="style9">
                      </td>
                  <td class="style9">
                      Quantity</td>
                  <td class="style9">
                      <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                  </td>
              </tr>
             
              <tr>
                  <td class="style7">
                      </td>
                  <td class="style7">
                      Total</td>
                  <td class="style7">
                      <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                  </td>
              </tr>
             
              <tr>
                  <td class="style7">
                      </td>
                  <td class="style7">
                      Card Number</td>
                  <td class="style7">
                      <asp:TextBox ID="TextBox1" runat="server" required="" TextMode="Number"></asp:TextBox>
                  </td>
              </tr>
             
              <tr>
                  <td class="style7">
                      </td>
                  <td class="style7">
                      Holder Name</td>
                  <td class="style7">
                      <asp:TextBox ID="TextBox2" runat="server" required=""></asp:TextBox>
                  </td>
              </tr>
             
              <tr>
                  <td class="style7">
                      </td>
                  <td class="style7">
                      CVV</td>
                  <td class="style7">
                      <asp:TextBox ID="TextBox3" runat="server" required="" TextMode="Number"></asp:TextBox>
                  </td>
              </tr>
             
              <tr>
                  <td class="style7">
                      </td>
                  <td class="style7">
                      Ex-Date</td>
                  <td class="style7">
                      <asp:TextBox ID="TextBox4" runat="server" required="" TextMode="Date"></asp:TextBox>
                  </td>
              </tr>
             
              <tr>
                  <td class="style7">
                      </td>
                  <td class="style7">
                      </td>
                  <td class="style7">
                      <asp:Button ID="Button1" runat="server" Text="Buy" onclick="Button1_Click" />
                  </td>
              </tr>
             
              <tr>
                  <td class="style4">
                      &nbsp;</td>
                  <td class="text-left">
                      &nbsp;</td>
                  <td class="text-left">
                      &nbsp;</td>
              </tr>
             
          </table>	
			                </td>
                        </tr>
                        
                    </table>

    <!-- about section -->
    <!-- //about section -->

    <!-- footer -->
    <footer class="w3l-footer-22 position-relative mt-5 pt-5">
       
        <!-- copyright -->
        <div class="copyright-footer text-center">
            <div class="container">
                <div class="columns">
                    <p>All rights reserved. Design by <a href="#"></a>
                        Admin</a>
                    </p>
                </div>
            </div>
        </div>
        <!-- //copyright -->
    </footer>
    <!-- //footer -->

    <!-- Js scripts -->
    <!-- move top -->
    <button onclick="topFunction()" id="movetop" title="Go to top">
        <span class="fa fa-level-up" aria-hidden="true"></span>
    </button>
    <script>
        // When the user scrolls down 20px from the top of the document, show the button
        window.onscroll = function () {
            scrollFunction()
        };

        function scrollFunction() {
            if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
                document.getElementById("movetop").style.display = "block";
            } else {
                document.getElementById("movetop").style.display = "none";
            }
        }

        // When the user clicks on the button, scroll to the top of the document
        function topFunction() {
            document.body.scrollTop = 0;
            document.documentElement.scrollTop = 0;
        }
    </script>
    <!-- //move top -->

    <!-- common jquery plugin -->
    <script src="assets/js/jquery-3.3.1.min.js"></script>
    <!-- //common jquery plugin -->

    <!-- magnific popup -->
    <script src="assets/js/jquery.magnific-popup.min.js"></script>
    <script>
        $(document).ready(function () {
            $('.popup-with-zoom-anim').magnificPopup({
                type: 'inline',

                fixedContentPos: false,
                fixedBgPos: true,

                overflowY: 'auto',

                closeBtnInside: true,
                preloader: false,

                midClick: true,
                removalDelay: 300,
                mainClass: 'my-mfp-zoom-in'
            });

            $('.popup-with-move-anim').magnificPopup({
                type: 'inline',

                fixedContentPos: false,
                fixedBgPos: true,

                overflowY: 'auto',

                closeBtnInside: true,
                preloader: false,

                midClick: true,
                removalDelay: 300,
                mainClass: 'my-mfp-slide-bottom'
            });
        });
    </script>
    <!-- //magnific popup -->

    <!-- counter for stats -->
    <script src="assets/js/counter.js"></script>
    <!-- //counter for stats -->

    <!-- theme switch js (light and dark)-->
    <script src="assets/js/theme-change.js"></script>
    <script>
        function autoType(elementClass, typingSpeed) {
            var thhis = $(elementClass);
            thhis.css({
                "position": "relative",
                "display": "inline-block"
            });
            thhis.prepend('<div class="cursor" style="right: initial; left:0;"></div>');
            thhis = thhis.find(".text-js");
            var text = thhis.text().trim().split('');
            var amntOfChars = text.length;
            var newString = "";
            thhis.text("|");
            setTimeout(function () {
                thhis.css("opacity", 1);
                thhis.prev().removeAttr("style");
                thhis.text("");
                for (var i = 0; i < amntOfChars; i++) {
                    (function (i, char) {
                        setTimeout(function () {
                            newString += char;
                            thhis.text(newString);
                        }, i * typingSpeed);
                    })(i + 1, text[i]);
                }
            }, 1500);
        }

        $(document).ready(function () {
            // Now to start autoTyping just call the autoType function with the 
            // class of outer div
            // The second paramter is the speed between each letter is typed.   
            autoType(".type-js", 200);
        });
    </script>
    <!-- //theme switch js (light and dark)-->

    <!-- MENU-JS -->
    <script>
        $(window).on("scroll", function () {
            var scroll = $(window).scrollTop();

            if (scroll >= 80) {
                $("#site-header").addClass("nav-fixed");
            } else {
                $("#site-header").removeClass("nav-fixed");
            }
        });

        //Main navigation Active Class Add Remove
        $(".navbar-toggler").on("click", function () {
            $("header").toggleClass("active");
        });
        $(document).on("ready", function () {
            if ($(window).width() > 991) {
                $("header").removeClass("active");
            }
            $(window).on("resize", function () {
                if ($(window).width() > 991) {
                    $("header").removeClass("active");
                }
            });
        });
    </script>
    <!-- //MENU-JS -->

    <!-- disable body scroll which navbar is in active -->
    <script>
        $(function () {
            $('.navbar-toggler').click(function () {
                $('body').toggleClass('noscroll');
            })
        });
    </script>
    <!-- //disable body scroll which navbar is in active -->

    <!--bootstrap-->
    <script src="assets/js/bootstrap.min.js"></script>
</asp:Content>

