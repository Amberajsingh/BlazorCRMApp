window.createDonutChart = (designations, userCounts) => {
    var ctx = document.getElementById('donutChart').getContext('2d');
    new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: designations,
            datasets: [{
                data: userCounts,
                backgroundColor: [
                    '#FF6384',
                    '#36A2EB',
                    '#FFCE56',
                    '#4BC0C0',
                    '#9966FF'
                ]
            }]
        },
        options: {
            //responsive: true,
            //maintainAspectRatio: false
        }
    });
};