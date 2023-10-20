let isFavorite = false;

        function toggleFavorite() {
            isFavorite = !isFavorite;
            const favoriteButton = document.querySelector('.favorite-button');
            const icon = favoriteButton.querySelector('i');
            icon.classList.add('animate');
            setTimeout(() => {
                icon.classList.remove('animate');
                if (isFavorite) {
                    icon.classList.remove('fa-heart');
                    icon.classList.add('fa-check');
                } else {
                    icon.classList.remove('fa-check');
                    icon.classList.add('fa-heart');
                }
            }, 200); // Время анимации в миллисекундах
        }