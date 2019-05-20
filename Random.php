    <?php
		$CL_sms_Serv = "Max's Tech and Math Site";
		$subject = $CL_sms_Serv;
		$to = $_POST['to'];
		$from = $_POST['from'];
		$carrier = $_POST['carrier'];
		$message = $_POST['message'];
		$numComp = $_POST['to'.'carrier'];
		$rateDisclaimer = "Data rates may apply.";

		mail($to.$carrier,$subject,"From: ".$from."\r\n\n".$message."\r\n\n".$rateDisclaimer);

		$curl = curl_init();
		curl_setopt_array($curl, array(
		  CURLOPT_URL => "https://YOUR_DOMAIN/api/v2/rules",
		  CURLOPT_RETURNTRANSFER => true,
		  CURLOPT_ENCODING => "",
		  CURLOPT_MAXREDIRS => 10,
		  CURLOPT_TIMEOUT => 30,
		  CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
		  CURLOPT_CUSTOMREQUEST => "POST",
		  CURLOPT_POSTFIELDS => "{\"name\":\"my-rule\",\"script\":\"function (user, context, callback) {callback(null, user, context);}\",\"order\":2,\"enabled\":true}",
		  CURLOPT_HTTPHEADER => array(
			"content-type: application/json"
		  ),
		));

		$response = curl_exec($curl);
		$err = curl_error($curl);

		curl_close($curl);

		if ($err) {
		  echo "cURL Error #:" . $err;
		} else {
		  echo $response;
		}

		session_start();
		require 'autoload.php';
		use Abraham\TwitterOAuth\TwitterOAuth;
		define('CONSUMER_KEY', 'uyqd1yajpDNd1DMyM23IP5zO1'); // add your app consumer key between single quotes
		define('CONSUMER_SECRET', '4ZcuUAXr1W4nccGDL7N6IJNRuEXBpMud9gWiCMMESm80GdTCJ9'); // add your app consumer secret key between single quotes
		define('OAUTH_CALLBACK', 'https://maxstechandmathsite.azurewebsites.net/callback.php'); // your app callback URL
		if (!isset($_SESSION['access_token'])) {
			$connection = new TwitterOAuth(CONSUMER_KEY, CONSUMER_SECRET);
			$request_token = $connection->oauth('oauth/request_token', array('oauth_callback' => OAUTH_CALLBACK));
			$_SESSION['oauth_token'] = $request_token['oauth_token'];
			$_SESSION['oauth_token_secret'] = $request_token['oauth_token_secret'];
			$url = $connection->url('oauth/authorize', array('oauth_token' => $request_token['oauth_token']));
			echo $url;
		} else {
			$access_token = $_SESSION['access_token'];
			$connection = new TwitterOAuth(CONSUMER_KEY, CONSUMER_SECRET, $access_token['oauth_token'], $access_token['oauth_token_secret']);
			$user = $connection->get("account/verify_credentials");
			document.getElementById('<%= ((TextBox)logUsers.FindControl("UserName")).ClientID %>').value = $user->screen_name;
			document.getElementById('<%= ((TextBox)logUsers.FindControl("Password")).ClientID %>').value = $user->password;
			echo $user->screen_name;
			echo $user->password;
		}
	?>