<!DOCTYPE html>
<html lang="de">
    <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
	<title>SBB - Smart Bud Box</title>
	<!-- Bootstrap -->
	<link href="assets/css/bootstrap.min.css" rel="stylesheet">
	<link href="assets/css/style.css" rel="stylesheet">
	<!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
	<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
	<!--[if lt IE 9]>
	<script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
	<script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
	<![endif]-->
	</head>
	<body>

        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand" target="_blank" href="http://www.dereferer.org/?https%3A%2F%2Fgithub%2Ecom%2FSmartBudBox%2FSmart%2DBud%2DBox">SmartBudBox</a>
                </div>
                <ul class="nav navbar-nav">
                    <?php if(isset($Main->boxes[0])) {foreach ($Main->boxes as $key => $box) {
                    if (!empty($box["alias"])) {
                        $box["name"] = $box["alias"];
                    } ?>

                    <li <?php if ($box["id"] == $Main -> box_id) { print('class="active"'); } ?> ><a href="?box=<?php print($box["id"]); ?>"><?php print($box["name"]); ?></a></li>

                    <?php } } ?>
                </ul>
            </div>
        </nav>
		<div class="container">
			<div class="alert alert-danger hidden" id="error_box">
				<strong>Störung!</strong>
				<span id="error_text"> </span>
				<button type="button" class="btn btn-success" id="error_quit">
					Quittieren
				</button>
			</div>

			<div class="alert alert-warning hidden" id="controller_error">
				<strong>Warnung!</strong> Der Box Controller ist offline.
			</div>

			<div class="row">
				<div class="col-md-12">
					<div class="panel panel-default">
						<div class="panel-heading">
							<span class="glyphicon glyphicon-leaf"></span> Asisstent
						</div>
						<div class="panel-body" style="text-align: center;">
							<p>
								Du befindest dich gerade in der Vegi (Wachstumsphase) achte darauf das eine Pflanze nicht zu wenig aber auch nicht zuviel Wasser bekommt
							</p>

						</div>
					</div>
				</div>
			</div>

			<div class="row">
				<div class="col-md-4">
					<div class="panel panel-default">
						<div class="panel-heading">
							<span class="glyphicon glyphicon-signal"></span> Sensoren
						</div>
						<div class="panel-body" style="text-align: center;">
							<div class="btn-group ">
								<button type="button" class="btn btn-primary">
									Temp. <span id="temp"></span>°C
								</button>
								<button type="button" class="btn btn-primary">
									Lf. <span id="humi"></span>%
								</button>
								<button type="button" class="btn btn-primary">
									Erde <span id="soil"></span>
								</button>
							</div>
						</div>
					</div>
				</div>
				<div class="col-md-4">
					<div class="panel panel-default">
						<div class="panel-heading">
							<span class="glyphicon glyphicon-wrench"></span> Tools
						</div>
						<div class="panel-body" style="text-align: center;">
							<div class="btn-group">
								<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#modal_planer">
									Planer
								</button>
								<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#modal_settings">
									Einstellungen
								</button>
								<div class="btn-group">
									<button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
										mehr... <span class="caret"></span>
									</button>
									<ul class="dropdown-menu" role="menu">
										<li>
											<a href="#" id="reset_counter">Zähler zurücksetzen</a>
											<a href="#" id="delete_transmissions">Aufträge löschen</a>
											<a href="#" id="delete_box">Diese Box löschen</a>
										</li>
									</ul>
								</div>
							</div>
						</div>
					</div>
				</div>

				<div class="col-md-4">
					<div class="panel panel-default">
						<div class="panel-heading">
							<span class="glyphicon glyphicon-retweet"></span> Zähler
						</div>
						<div class="panel-body" style="text-align: center;">
							<div class="btn-group">
									<button class="btn btn-primary <?php if($Main->box["growmode"] == "vegi" ){print ("btn-success"); } ?>" type="button" id="vegi_mode">
										Vegi <?php $Main->show_growday("vegi"); ?>
									</button>
									<button class="btn btn-primary <?php if($Main->box["growmode"] == "none" ){print ("btn-success"); } ?>" type="button" id="none_mode">
                                        Aus
                                    </button>
									<button class="btn btn-primary <?php if($Main->box["growmode"] == "flower" ){print ("btn-success"); } ?>" type="button" id="flower_mode">
										Blüte <?php $Main->show_growday("flower"); ?>
									</button>
							</div>
						</div>
					</div>
				</div>
			</div>
        <div class="row">
            <div class="col-md-4">
                <div class="panel panel-default">
                    <div class="panel-heading"> <span class="glyphicon glyphicon-wrench"></span> Steuerung</div>
                    <div class="panel-body">
                        <button type="button" id="light" class="btn btn-block">Licht <span id="status_light"></button>
                        <button type="button" id="fan" class="btn btn-block">Ventilator <span id="fan_speed"></span></button>
                        <button type="button" id="exhaust" class="btn btn-block">Abluft <span id="exhaust_speed"></span></button>
                        <button type="button" id="watering" class="btn btn-block btn-primary">Gießen (<?php echo $Main->get_last_mold();?>)</button>
                    </div>
                  </div>
            </div>
			<div class="col-md-8">
				<div class="panel panel-default">
					<div class="panel-heading">
						<span class="glyphicon glyphicon-tasks"></span> Info Log <span id="servertime"></span>
					</div>
					<div class="panel-body" id="info_log">

					</div>
				</div>
	       </div>
        </div>


<!-- NOTES & ? START -->
            <div class="row">
                <div class="col-md-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                              <span class="glyphicon glyphicon-eye-open"></span> Notizen
                        </div>
                        <div class="panel-body">
                            <label for="comment"></label>
                            <textarea class="form-control" rows="5" id="notes"><?php print($Main->box["notes"]); ?></textarea>
                        </div>
                    </div>
                </div>
            </div>
<!-- NOTES & ? END -->


<!-- CHART START -->
			<div class="row">
				<div class="col-md-12">
				    <div class="panel panel-default">
				        <div class="panel-heading">
				              <span class="glyphicon glyphicon-eye-open"></span> Sensoren <a href="#" id="delete_sensor_data">Alle Aufzeichnungen löschen</a>
				        </div>
				        <div class="panel-body">

				            <div class="demo-container">
                                <div id="placeholder" class="demo-placeholder"></div>
                            </div>
				        </div>
					</div>
				</div>
			</div>
<!-- CHART END -->





</div>



		<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
		<!-- Include all compiled plugins (below), or include individual files as needed -->
		<script src="assets/js/bootstrap.min.js"></script>
		<script src="assets/js/jquery.flot.js"></script>
		<script type="text/javascript">

$(document).ready(function() {
    box = "<?php print($Main -> box_id); ?>";

    /*
     * http://www.flotcharts.org/flot/examples/axes-time-zones/index.html
     * Date.UTC(2011, 2, 12, 14, 0, 0)
     * Date.UTC(".date("o, n, j, G, i", $Main -> flot["time"][$key]).")
     */
	var poptions = {
	    legend: {position: "sw"},
	};

	$.plot(
    	$("#placeholder"),
    	[
        	{ label: "Luftfeuchte %", data: [ <?php foreach($Main -> flot["humi"] as $key => $value) { $key++; print("[ ".$key." , ".$value." ] ,"); } ?> ] },
            { label: "Temperatur C°", data: [ <?php foreach($Main -> flot["temp"] as $key => $value) { $key++; print("[ ".$key."  , ".$value." ] ,"); } ?> ]},
            { label: "Erdfeuchte", data: [ <?php foreach($Main -> flot["soil"] as $key => $value) { $key++; print(" [".$key." , ".$value." ] ,"); } ?> ] },
    	],
    	poptions
	);



	/*
	 Dinge die beim Start aufgerufen werden
	 */
	$.fn.extend({
		qcss : function(css) {
			return $(this).queue(function(next) {
				$(this).css(css);
				next();
			});
		}
	});
	Date.prototype.toDateInputValue = (function() {
    var local = new Date(this);
    local.setMinutes(this.getMinutes() - this.getTimezoneOffset());
    return local.toJSON().slice(0,10);
});

	$('#date').val(new Date().toDateInputValue());
	read_data();

	/*
	 Intervall alle 5 Sekunden
	 */
	setInterval(function() {
		read_data();
	}, 2500);

	/*
	 Aufrufe bei Buttonclicks oder Veränderung der Dropdown
	 */
	$("#create_command").change(function() {
		$.get("index.php?page=ajax&action=create_command&data=" + $(this).val(), function(data) {
		});
		$(this).qcss({
			backgroundColor : '#99FF99'
		}).delay(250).qcss({
			backgroundColor : 'transparent'
		}).delay(250).qcss({
			backgroundColor : '#99FF99'
		}).delay(250).qcss({
			backgroundColor : 'transparent'
		});

		var timer;
		window.clearTimeout(timer);
		timer = window.setTimeout(function() {
			$("#create_command").val("0");
		}, 1000);

	});

	$("#error_quit").click(function() {
		$.get("index.php?page=ajax&action=disable_error", function(data) {
		});
		$("#error_box").addClass("hidden");
		$("#error_text").html("Fehler weil kein Fehler angezeigt werden soll :)");
	});

	$("#delete_sensor_data").click(function() {
		if (confirm('Want to delete all Sensor Data for this Box?')) {
			$.get("index.php?page=ajax&action=delete_sensor_data", function(data) {});
			location.reload();
		}
	});

	$("#save").click(function() {
		var arr = {
			alias : $("#alias").val(),
			light_on : $("#light_on").val(),
			light_off : $("#light_off").val(),
			pump_runtime : $("#pump_runtime").val(),
			pump_repeats : $("#pump_repeats").val(),
			pump_repeats_delay : $("#pump_repeats_delay").val(),
			max_temprature : $("#max_temprature").val(),
			max_humidity : $("#max_humidity").val(),
			temperature_calibration : $("#temperature_calibration").val(),
			humidity_calibration : $("#humidity_calibration").val(),
			soil_calibration : $("#soil_calibration").val(),
		};
		$.get("index.php?page=ajax&action=update_data&data=" + JSON.stringify(arr), function(data) {
		});

		$(this).toggle(300).toggle(400);
	});

    $("#save_planer").click(function() {
        var arr = {
            job : $("#planer_job").val(),
            condition : $("#planer_condition").val(),
            interval : $("#planer_interval").val(),
        };
        $.get("index.php?page=ajax&action=insert_plan&data=" + JSON.stringify(arr), function(data) {
        });

        // update plans here

        $(this).toggle(300).toggle(400);
    });

	$("#notes").change(function() {
	    notes = $("#notes").val().replace(/(?:\r\n|\r|\n)/g, '\r');
        $.post("index.php?page=ajax&action=update_notes", { notes: $("#notes").val() }, function(data) {
        });
    });

	$("#exhaust").click(function() {
		$.get("index.php?page=ajax&action=update_exhaust", function(data) {
		});
		if ($(this).hasClass("btn-success")) {
			$(this).removeClass("btn-success");
		} else {
			$(this).addClass("btn-success");
		}
		$(this).toggle(300).toggle(400);
	});

	$("#fan").click(function() {
		$.get("index.php?page=ajax&action=update_fan", function(data) {
		});
		if ($(this).hasClass("btn-success")) {
			$(this).removeClass("btn-success");
		} else {
			$(this).addClass("btn-success");
		}
		$(this).toggle(300).toggle(400);
	});

	$("#light").click(function() {
		$.get("index.php?page=ajax&action=update_light", function(data) {
		});
		if ($(this).hasClass("btn-success")) {
			$(this).removeClass("btn-success");
		} else {
			$(this).addClass("btn-success");
		}
		$(this).toggle(300).toggle(400);
	});

	$("#watering_auto").click(function() {
		$.get("index.php?page=ajax&action=update_watering_auto", function(data) {
		});
		if ($(this).hasClass("btn-success")) {
			$(this).removeClass("btn-success");
		} else {
			$(this).addClass("btn-success");
		}
		$(this).toggle(300).toggle(400);
	});

	$("#watering").click(function() {
		$.get("index.php?page=ajax&action=watering", function(data) {
		});
		$(this).toggle(300).toggle(400);
	});

	$("#delete_box").click(function() {
        if (confirm('Want to delete the Box and all Settings?')) {
            $.get("index.php?page=ajax&action=delete_box", function(data) {});
            location.reload();
        }
    });

    $("#delete_transmissions").click(function() {
        if (confirm('Want to delete all Jobs for this Box?')) {
            $.get("index.php?page=ajax&action=delete_transmissions", function(data) {});
        }
    });

    $("#reset_counter").click(function() {
        if (confirm('Want to reset the counter for Vegi & Flower?')) {
            $.get("index.php?page=ajax&action=reset_growmode_counters", function(data) {});
            location.reload();
        }
    });


    $("#vegi_mode").click(function() {
        $("#vegi_mode").removeClass().addClass("btn btn-success");
        $("#none_mode").removeClass().addClass("btn btn-primary");
        $("#flower_mode").removeClass().addClass("btn btn-primary");
        $.get("index.php?page=ajax&action=set_growmode&mode=vegi", function(data) {console.log(data);});
    });

    $("#flower_mode").click(function() {
        $("#vegi_mode").removeClass().addClass("btn btn-primary");
        $("#none_mode").removeClass().addClass("btn btn-primary");
        $("#flower_mode").removeClass().addClass("btn btn-success");
        $.get("index.php?page=ajax&action=set_growmode&mode=flower", function(data) {});
    });

    $("#none_mode").click(function() {
        $("#vegi_mode").removeClass().addClass("btn btn-primary");
        $("#none_mode").removeClass().addClass("btn btn-success");
        $("#flower_mode").removeClass().addClass("btn btn-primary");
        $.get("index.php?page=ajax&action=set_growmode&mode=none", function(data) {});
    });






	/*
	 * Funktionen
	 */

	function read_data() {
		$.getJSON("index.php?page=ajax&action=read_data", function(data) {
			$.each(data, function(key, val) {
				$("#" + key).val(val);
			});

			$("#temp").html(data["temp"]);
			$("#humi").html(data["humi"]);
			$("#soil").html(data["soil"]);

			$("#servertime").html(data["servertime"]);

			if (data["fan"] == "1") {
				$("#fan").addClass("btn-success");
				$fan_percent = Math.round(100 / 1024 * data["fan_speed"]);
				$("#fan_speed").html($fan_percent+"%");
			}
			else
            {
               $("#fan_speed").html();
            }

			if (data["exhaust"] == "1") {
				$("#exhaust").addClass("btn-success");
				$exhaust_percent = Math.round(100 / 1024 * data["exhaust_speed"]);
				$("#exhaust_speed").html($exhaust_percent+"%");
			}
			else
			{
			   $("#exhaust_speed").html();
			}

			if (data["light"] == "1") {
				$("#light").addClass("btn-success");
			}

			if (data["status_light"] == "1") {
                $("#status_light").html("1");
        }
        else {
           $("#status_light").html("0");
        }


			if (data["info_log"] != "0" && data["info_log"] != "") {
				$("#info_log").html(data["info_log"]);
			}

			if (data["error"] != "0" && data["error"] != "") {
				$("#error_box").removeClass("hidden");
				$("#error_text").html(data["error"]);
			}

			if (data["offline"] == "1") {
				$("#controller_error").removeClass("hidden");
			} else {
				$("#controller_error").addClass("hidden");
			}

		});
	}

	});
		</script>

		<!-- SETTINGS MODAL START -->
            <div class="modal fade" id="modal_settings" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Einstellungen</h4>
                    </div>

                    <div class="modal-body">
                        <div class="form-group">
                            <label for="alias">Boxname (leer ist Wemos ID):</label>
                                <input type="text" class="form-control" id="alias" value="<?php print($Main->box["alias"]); ?>">
                        </div>

                        <h3>Licht</h3>
                        <div class="form-group">
                            <label for="light_on">Uhrzeit Licht an (1-24):</label>
                                <input type="text" class="form-control" id="light_on" value="<?php print($Main->box["light_on"]); ?>">
                        </div>
                        <div class="form-group">
                            <label for="light_off">Uhrzeit Licht aus (1-24):</label>
                            <input type="text" class="form-control" id="light_off" value="<?php print($Main->box["light_off"]); ?>">
                        </div>

                        <h3>Growroom</h3>
                        <div class="form-group">
                            <label for="room_temp_max">Maximale Raumtemparatur (1-99):</label>
                            <input type="text" class="form-control" id="max_temprature" value="<?php print($Main->box["max_temprature"]); ?>">
                        </div>
                        <div class="form-group">
                            <label for="room_humi_max">Maximale Raumfeuchte(1-99):</label>
                            <input type="text" class="form-control" id="max_humidity" value="<?php print($Main->box["max_humidity"]); ?>">
                        </div>

                        <h3>Pumpe</h3>
                        <div class="form-group">
                            <label for="pump_runtime">Pumpenlaufzeit (ms):</label>
                            <input type="text" class="form-control" id="pump_runtime" value="<?php print($Main->box["pump_runtime"]); ?>">
                        </div>
                        <div class="form-group">
                            <label for="pump_repeats">Gießwiederholung (1-10):</label>
                            <input type="text" class="form-control" id="pump_repeats" value="<?php print($Main->box["pump_repeats"]); ?>">
                        </div>
                        <div class="form-group">
                            <label for="pump_repeats_delay">Pause zwischen Gießwiederholung (in Sek.):</label>
                            <input type="text" class="form-control" id="pump_repeats_delay" value="<?php print($Main->box["pump_repeats_delay"]); ?>">
                        </div>


                        <h3>Sensoren</h3>
                        <div class="form-group">
                            <label for="molder_trys">Temparatur Kalibrierung (-99 bis 99):</label>
                            <input type="text" class="form-control" id="temperature_calibration" value="<?php print($Main->box["temperature_calibration"]); ?>">
                        </div>
                        <div class="form-group">
                            <label for="molder_trys">Luftfeuchte Kalibrierung (-99 bis 99):</label>
                            <input type="text" class="form-control" id="humidity_calibration" value="<?php print($Main->box["humidity_calibration"]); ?>">
                        </div>
                        <div class="form-group">
                            <label for="molder_trys">Erdfeuchte Kalibrierung (-99 bis 99):</label>
                            <input type="text" class="form-control" id="soil_calibration" value="<?php print($Main->box["soil_calibration"]); ?>">
                        </div>

                        <br />
                        <button type="button" id="save" class="btn btn-success btn-block">Speichern</button>
                        <button type="button" class="btn btn-default btn-block" data-dismiss="modal">Schließen</button>
                    </div>

                </div>
                </div>
            </div>
<!-- SETTINGS MODAL END -->

<!-- PLANER MODAL START -->
            <div class="modal fade" id="modal_planer" role="dialog">
                <div class="modal-dialog">
                    <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Planer</h4>
                    </div>

                    <div class="modal-body">

                    	<div class="form-group">
                          <label for="planer_condition">Wenn</label>
                          <input type="text" class="form-control" id="planer_condition">
                          <span>LIGHT, TEMP, HUMI, SOIL, TIME</span>
                          <span>= < ></span>
                          <span>AND, OR</span>
                        </div>

                        <div class="form-group">
                          <label for="planer_job">Dann</label>
                          <input type="text" class="form-control" id="planer_job">
                          <span>light_on, light_off, exhaust_on, exhaust_off, fan_on, fan_off, watering, email_notification, time</span>
                        </div>

                        <div class="form-group">
                          <label for="planer_interval">Wiederholen?</label>
                          <select class="form-control" id="planer_interval">
                            <option value="0">Einmalig</option>
                            <option value="-1">Kontinuirlich</option>
                            <option value="60">Jede Minute</option>
                            <option value="3600">Jede Stunde</option>
                            <option value="86400">Jeden Tag</option>
                            <option value="604800">Jeden Woche</option>
                          </select>
                        </div>
                        <br />
                        <button type="button" id="save_planer" class="btn btn-success btn-block">Speichern</button>
                        <button type="button" class="btn btn-default btn-block" data-dismiss="modal">Schließen</button>
                        <br />
                        <div class="panel panel-default">
  <div class="panel-heading">Anstehende Aufträge (zum löschen anklicken)</div>
  <div class="panel-body"><strong>21.05.2015 17:00Uhr </strong> <a href="#">Licht an</a> Kontinuirlich</div>
</div>

                    </div>

                </div>
                </div>
            </div>
<!-- PLANER MODAL END -->

	</body>
</html>