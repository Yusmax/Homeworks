// Function to check if the website is opened on a screen smaller than 1920 pixels in width
function isScreenSmallerThan1920() {
    return window.innerWidth < 1920;
}

// Function to disable or enable the swupInstaller.js script based on screen size
function toggleSwupInstallerScript() {
    const script = document.querySelector('script[src="/scripts/swupInstaller.js"]');

    if (script) {
        if (isScreenSmallerThan1920()) {
            script.disabled = true; // Disable the script
        } else {
            script.disabled = false; // Enable the script
        }
    }
} 

// Run the function when the DOM is loaded and when the window is resized
document.addEventListener('DOMContentLoaded', toggleSwupInstallerScript);
window.addEventListener('resize', toggleSwupInstallerScript);
