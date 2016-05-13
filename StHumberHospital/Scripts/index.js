//WAIT FOR THE PAGE TO LOAD AND THEN ACCESS ALL ELEMENTS
window.onload = pageLoaded;
function pageLoaded() {
    var toggleMenuBtn = document.getElementById("toggle-menu");
    var miniNav = document.getElementById("mini-nav");
    toggleMenuBtn.onclick = toggleResponsiveMenu;
//THIS FUNCTION IS FOR THE RESPONSIVE NAVIGATION MENU - DROP DOWN
    function toggleResponsiveMenu() {
        if(miniNav.className === "toggleHide")
        {
            miniNav.className = "row show";
        } else {
            miniNav.className = "toggleHide";
        }
    };
}