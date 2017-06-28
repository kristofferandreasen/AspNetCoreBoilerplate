jQuery(document).ready(function($) {
    
    // -------------------------------------------------------------------------------------
    // Smooth scroll to top
    // -------------------------------------------------------------------------------------

    $('#scrollToTop').on('click', function(e){
        $("html, body").animate({scrollTop: $("#top_anchor").offset().top}, 1500);
    });

    // -------------------------------------------------------------------------------------
    // Smooth scroll to anchor
    // -------------------------------------------------------------------------------------
    
    $('#scrollBtn').on('click', function(event){
        event.preventDefault();

        $('html, body').animate({
            scrollTop: $( $.attr(this, 'href') ).offset().top
        }, 1000);
    });

    // -------------------------------------------------------------------------------------
    // Testimonials Carousel
    // -------------------------------------------------------------------------------------

    $('#quote-carousel').carousel({
        pause: true, interval: 8000,
    });

    // -------------------------------------------------------------------------------------
    // Modal Functions
    // -------------------------------------------------------------------------------------
    
    // Check if the modal exists on page
    if (document.getElementById('myModal') != null) {
    
        // Get the modal
        var modal = document.getElementById('myModal');

        // Get the button that opens the modal
        var btn = document.getElementById("myBtn");
        
        
        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName("close")[0];

        // When the user clicks the button, open the modal 
        btn.onclick = function() {
            modal.style.display = "block";
        }

        // When the user clicks on <span> (x), close the modal
        span.onclick = function() {
            modal.style.display = "none";
        }

        // When the user clicks anywhere outside of the modal, close it
        document.onclick = function(event) {
            if (event.target == modal) {
                modal.style.display = "none";
            }
        }

    }
    // End of Modal Function


    // -------------------------------------------------------------------------------------
    // Simple Modal Functions
    // -------------------------------------------------------------------------------------
    
    // Check if the modal exists on page
    if (document.getElementById('mySimpleModal') != null) {
    
        // Get the modal
        var simpleModal = document.getElementById('mySimpleModal');

        // Get the button that opens the modal
        var btn = document.getElementById("my_Simple_Modal_Btn");
        
        
        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName("simple_close")[0];

        // When the user clicks the button, open the modal 
        btn.onclick = function() {
            simpleModal.style.display = "block";
        }

        // When the user clicks on <span> (x), close the modal
        span.onclick = function() {
            simpleModal.style.display = "none";
        }

        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function(event) {
            if (event.target == simpleModal) {
                simpleModal.style.display = "none";
            }
        }

    }
    // End of Modal Function

});