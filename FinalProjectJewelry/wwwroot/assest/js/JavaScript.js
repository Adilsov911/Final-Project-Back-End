



$(".addtobasket").click(function (e) {
    e.preventDefault();

    let url = $(this).attr("href");

    fetch(url)
        .then(res => {
            return res.text();
        })
        .then(data => {
            $(".Carts").html(data);
        })
})

$(function () {
    $('.Slider').slick({

        infinite: true,
        speed: 1650,
        fade: true,
        cssEase: 'linear',
        prevArrow: '<span class="priv-arrow"><i class="fa-solid fa-angle-left"></i></span>',
        nextArrow: '<span class="next-arrow"><i class="fa-solid fa-chevron-right"></i></span>'
    });
});
$(function () {

    $('.carousel').slick({
        infinite: true,
        speed: 300,
        slidesToShow: 3,
        slidesToScroll: 4,
        prevArrow: '<span class="priv-arrow"><i class="fa-solid fa-angle-left"></i></span>',
        nextArrow: '<span class="next-arrow"><i class="fa-solid fa-chevron-right"></i></span>',
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 3,
                    infinite: true,

                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
            // You can unslick at a given breakpoint now by adding:
            // settings: "unslick"
            // instead of a settings object
        ]
    });
})
$(function () {

    $('.carousel-brand').slick({
        infinite: true,
        speed: 300,
        slidesToShow: 6,
        slidesToScroll: 1,
        prevArrow: '<span class="priv-arrow"><i class="fa-solid fa-angle-left"></i></span>',
        nextArrow: '<span class="next-arrow"><i class="fa-solid fa-chevron-right"></i></span>',
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,

                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
            // You can unslick at a given breakpoint now by adding:
            // settings: "unslick"
            // instead of a settings object
        ]
    });
})

   


//$(document).ready(() => {


//    $(".bas").click(() => {
//        let searchInput = $(".axtar").val();
       
        
//        fetch('/shop/Search/' + 'search=' + searchInput)
       
//           then(response => {
//             return response.json();
//          }).then(data => {
//                 console.log(data)
//                    let liItems = '';

//                    for (var i = 0; i < data.length; i++) {
//                        let liItems = `<li>
//                            <img width = "100" src = "~/assets/images/product/${data[i].image}" alt = "Alternate Text" />
//                                <a asp-controller="shop" asp-action="detail" asp-route-id="@productListVM.Id">${data[i].title}</a>
//                              </li>`
//                        liItems += liItems;

//                        console.log(liItems)

//                    }
//              })


        

//    })


//    //$(document).on("click", function (e) {
//    //    let name = e.target.;
//    //    if (name != "searchInput") {
//    //        $("#searchList").html('');
//    //    }
//    //})
//})