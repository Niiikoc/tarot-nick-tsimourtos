
Public Class Form1
    Dim ButtonOneClick, buttontwoclick, buttonthreeclick, buttonfourclick As Boolean
    Dim random1 As Byte
    Dim random2 As Byte
    Dim random3 As Byte
    Dim random4 As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ButtonOneClick = True

        Randomize()
        random1 = (Rnd() * 5) + 1
        If random1 = 1 Then
            PictureBox1.Image = My.Resources.devil
            Dim a As String = "Μμμμ.. όχι και τόσο καλό!! Σε βασανίζει ενα απο τους μεγαλύτερους φόβους σου, και ανησυχείς για τα παραπτώματα σου. Έχεις βρει τον μπελά σου. ΚΑΛΑ ΝΑ ΠΆΘΕΙΣ!!!"
            TextBox1.Text = a
        End If
        If random1 = 2 Then
            PictureBox1.Image = My.Resources.apofash
            Dim b As String = "Έχεις βρεθεί σε μια δύσκολη κατάσταση και πρέπει να πάρεις μια απόφαση. Βίασου πριν είναι αργά. Οι παράφρονες καραδοκούν"
            TextBox1.Text = b
        End If
        If random1 = 3 Then
            PictureBox1.Image = My.Resources.chariot
            Dim c As String = "Είσαι ενα αποφασιστικός ανθρώπος, με δύναμη και επιβολή και σύμμαχο την επιτυχία. Τίποτα ομως δενε είναι βέβαιο. Στην θέση σου θα κάλυπτα τα νώτα μου."
            TextBox1.Text = c
        End If
        If random1 = 4 Then
            PictureBox1.Image = My.Resources.death
            Dim d As String = "Σύντομα κάτι πρέπει να πεθάνει. Μην ανησυχείς δεν είναι άνθρωπος. Μάλλον τα κουρνιασμένα ονείρα που φυλάς καιρό. Κάτι καινούργιο σε περιμένει!! 'Ισως....."
            TextBox1.Text = d
        End If
        If random1 = 5 Then
            PictureBox1.Image = My.Resources.sun
            Dim x As String = "Προβλέπεται αισιοδοξία, χαρά και φώς... Πριν έρθει το σκοτάδι.. "
            TextBox1.Text = x
        End If
        If random1 = 6 Then
            PictureBox1.Image = My.Resources.world
            Dim f As String = "Έχεις ολοκληρώσει ενα σημαντικό στάδιο της ζωής σου. Αύτο είναι ευτυχία. Αλλά ξέρεις ποιός γελάει καλύτερα!! "
            TextBox1.Text = f
        End If
        If random1 = 7 Then
            PictureBox1.Image = My.Resources.egkrateia
            Dim g As String = "Άκου.. Να εισαι προσεκτικός. Να υπάρχει μια εγκράτεια στις επιλογές ή αποφάσεις σου. Αλλιώς θα καταλήξεις σαν τον Ίκαρο.."
            TextBox1.Text = g
        End If
        If random1 = 8 Then
            PictureBox1.Image = My.Resources.emperor
            Dim i As String = "θα σου συμβούλευα να μη τρέξεις σήμερα με την μηχανή σου. Παραμονεύει η αστυνομία. Εκτός και μπορείς να ξεφύγεις. Τότε γκάζωσε το!!!!!!"
            TextBox1.Text = i
        End If
        If random1 = 9 Then
            PictureBox1.Image = My.Resources.hangedman
            Dim j As String = "Προβλέπεται δύσκολη εβδομάδα. Το νου σου μην σε κρεμάσουν οι φίλοι σου ή οι συγγενείς σου"
            TextBox1.Text = j
        End If
        If random1 = 10 Then
            PictureBox1.Image = My.Resources.justice
            Dim k As String = "Έχεις κάποιες σοβαρές εκκρεμότητες. Τακτοποίησε τες αν θες να έρθει η δικαιοσύνη. Αλλιώς θα σε κηνυγάνε σαν τον βάζελο και εσένα.."
            TextBox1.Text = k
        End If
        If random1 = 11 Then
            PictureBox1.Image = My.Resources.lover
            Dim l As String = "Ο/Η σύντροφος σου έχει καταλάβει κάτι. Μπορεί να προκύψει μια μη αναμενόμενη συνάντηση με τον/την εραστή σου. Όπως έστρωσες θα κοιμηθείς... χα χα χα"
            TextBox1.Text = l
        End If
        If random1 = 12 Then
            PictureBox1.Image = My.Resources.magician
            Dim m As String = "Χμμμ μια εξυπνάδα να διαχειρίζεσαι τους στόχους σου την έχεις. Το νου σου, μην δαγκώσεις και εσυ το δηλητήριο σου"
            TextBox1.Text = m
        End If
        If random1 = 13 Then
            PictureBox1.Image = My.Resources.moon
            Dim n As String = "θα ζήσεις μία κατάσταση με ανάμεικτα συναισθήματα.. Κοίτα να το απολαύσεις..."
            TextBox1.Text = n
        End If
        If random1 = 14 Then
            PictureBox1.Image = My.Resources.profhths
            Dim p As String = "Δεν άκουγες τις προφητείες του Παϊσιου. Έπεξες με τις φλώγες και κάηκες"
            TextBox1.Text = p
        End If
        If random1 = 15 Then
            PictureBox1.Image = My.Resources.strenght
            Dim q As String = "Καλό θα ηταν να γραφτείς στο γυμναστήριο μπας και αυξύσεις λιγο την δύναμη σου άνθρωπε του καναπέ"
            TextBox1.Text = q
        End If
        If random1 = 16 Then
            PictureBox1.Image = My.Resources.wheel
            Dim r As String = "Τι θέλεις ακριβώς να σου πω? το λέει και μόνο του... Ρόδα είναι και γυρίζει. Εκτός και αν παίξεις καμία ρώσικη ρουλέτα.."
            TextBox1.Text = r
        End If
        If random1 = 17 Then
            PictureBox1.Image = My.Resources.tower
            Dim s As String = "Απέτυχες παταγωδώς. Το μόνο που βλέπω για σένα είναι χάος."
            TextBox1.Text = s
        End If
        If random1 = 18 Then
            PictureBox1.Image = My.Resources.fool
            Dim w As String = "Είσαι ένας χαρακτήρας που δεν κοιτάει τι θα πουν οι άλλοι, ζεις την ζωή σου με τρέλα αλλά να ξέρεις είναι πολύ σύντομη."
            TextBox1.Text = w
        End If
        Button2.Visible = True
        PictureBox5.Visible = True
        TextBox2.Visible = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        buttontwoclick = True
        Randomize()
        random2 = (Rnd() * 5) + 1
        If random2 = 1 And random1 <> 1 And random3 <> 1 And random4 <> 1 Then
            PictureBox5.Image = My.Resources.emperor
            Dim i As String = "θα σου συμβούλευα να μη τρέξεις σήμερα με την μηχανή σου. Παραμονεύει η αστυνομία. Εκτός και μπορείς να ξεφύγεις. Τότε γκάζωσε το!!!!!!"
            TextBox2.Text = i
        End If
        If random2 = 2 And random1 <> 2 And random3 <> 2 And random4 <> 2 Then
            PictureBox5.Image = My.Resources.hangedman
            Dim j As String = "Προβλέπεται δύσκολη εβδομάδα. Το νου σου μην σε κρεμάσουν οι φίλοι σου ή οι συγγενείς σου"
            TextBox2.Text = j
        End If
        If random2 = 3 And random1 <> 3 And random3 <> 3 And random4 <> 3 Then
            PictureBox5.Image = My.Resources.justice
            Dim k As String = "Έχεις κάποιες σοβαρές εκκρεμότητες. Τακτοποίησε τες αν θες να έρθει η δικαιοσύνη. Αλλιώς θα σε κηνυγάνε σαν τον βάζελο και εσένα.."
            TextBox2.Text = k
        End If
        If random2 = 4 And random1 <> 4 And random3 <> 4 And random4 <> 4 Then
            PictureBox5.Image = My.Resources.lover
            Dim l As String = "Ο/Η σύντροφος σου έχει καταλάβει κάτι. Μπορεί να προκύψει μια μη αναμενόμενη συνάντηση με τον/την εραστή σου. Όπως έστρωσες θα κοιμηθείς... χα χα χα"
            TextBox2.Text = l
        End If
        If random2 = 5 And random1 <> 5 And random3 <> 5 And random4 <> 5 Then
            PictureBox5.Image = My.Resources.magician
            Dim m As String = "Χμμμ μια εξυπνάδα να διαχειρίζεσαι τους στόχους σου την έχεις. Το νου σου, μην δαγκώσεις και εσυ το δηλητήριο σου"
            TextBox2.Text = m
        End If
        If random2 = 6 And random1 <> 6 And random3 <> 6 And random4 <> 6 Then
            PictureBox5.Image = My.Resources.moon
            Dim n As String = "θα ζήσεις μία κατάσταση με ανάμεικτα συναισθήματα.. Κοίτα να το απολαύσεις..."
            TextBox2.Text = n
        End If
        If random2 = 7 And random1 <> 7 And random3 <> 7 And random4 <> 7 Then
            PictureBox5.Image = My.Resources.profhths
            Dim p As String = "Δεν άκουγες τις προφητείες του Παϊσιου. Έπεξες με τις φλώγες και κάηκες"
            TextBox2.Text = p
        End If
        If random2 = 8 And random1 <> 8 And random3 <> 8 And random4 <> 8 Then
            PictureBox5.Image = My.Resources.strenght
            Dim q As String = "Καλό θα ηταν να γραφτείς στο γυμναστήριο μπας και αυξύσεις λιγο την δύναμη σου άνθρωπε του καναπέ"
            TextBox2.Text = q
        End If
        If random2 = 9 And random1 <> 9 And random3 <> 9 And random4 <> 9 Then
            PictureBox5.Image = My.Resources.wheel
            Dim r As String = "Τι θέλεις ακριβώς να σου πω? το λέει και μόνο του... Ρόδα είναι και γυρίζει. Εκτός και αν παίξεις καμία ρώσικη ρουλέτα.."
            TextBox2.Text = r
        End If
        If random2 = 10 And random1 <> 10 And random3 <> 10 And random4 <> 10 Then
            PictureBox5.Image = My.Resources.tower
            Dim s As String = "Απέτυχες παταγωδώς. Το μόνο που βλέπω για σένα είναι χάος."
            TextBox2.Text = s
        End If
        If random2 = 11 And random1 <> 11 And random3 <> 11 And random4 <> 11 Then
            PictureBox5.Image = My.Resources.fool
            Dim w As String = "Είσαι ένας χαρακτήρας που δεν κοιτάει τι θα πουν οι άλλοι, ζεις την ζωή σου με τρέλα αλλά να ξέρεις είναι πολύ σύντομη."
            TextBox2.Text = w
        End If
        If random2 = 12 And random1 <> 12 And random3 <> 12 And random4 <> 12 Then
            PictureBox5.Image = My.Resources.devil
            Dim a As String = "Μμμμ.. όχι και τόσο καλό!! Σε βασανίζει ενα απο τους μεγαλύτερους φόβους σου, και ανησυχείς για τα παραπτώματα σου. Έχεις βρει τον μπελά σου. ΚΑΛΑ ΝΑ ΠΆΘΕΙΣ!!!"
            TextBox2.Text = a
        End If
        If random2 = 13 And random1 <> 13 And random3 <> 13 And random4 <> 13 Then
            PictureBox5.Image = My.Resources.apofash
            Dim b As String = "Έχεις βρεθεί σε μια δύσκολη κατάσταση και πρέπει να πάρεις μια απόφαση. Βίασου πριν είναι αργά. Οι παράφρονες καραδοκούν"
            TextBox2.Text = b
        End If
        If random2 = 14 And random1 <> 14 And random3 <> 14 And random4 <> 14 Then
            PictureBox5.Image = My.Resources.chariot
            Dim c As String = "Είσαι ενα αποφασιστικός ανθρώπος, με δύναμη και επιβολή και σύμμαχο την επιτυχία. Τίποτα ομως δενε είναι βέβαιο. Στην θέση σου θα κάλυπτα τα νώτα μου."
            TextBox2.Text = c
        End If
        If random2 = 15 And random1 <> 15 And random3 <> 15 And random4 <> 15 Then
            PictureBox5.Image = My.Resources.death
            Dim d As String = "Σύντομα κάτι πρέπει να πεθάνει. Μην ανησυχείς δεν είναι άνθρωπος. Μάλλον τα κουρνιασμένα ονείρα που φυλάς καιρό. Κάτι καινούργιο σε περιμένει!! 'Ισως....."
            TextBox2.Text = d
        End If
        If random2 = 16 And random1 <> 16 And random3 <> 16 And random4 <> 16 Then
            PictureBox5.Image = My.Resources.sun
            Dim x As String = "Προβλέπεται αισιοδοξία, χαρά και φώς... Πριν έρθει το σκοτάδι.. "
            TextBox2.Text = x
        End If
        If random2 = 17 And random1 <> 17 And random3 <> 17 And random4 <> 17 Then
            PictureBox5.Image = My.Resources.world
            Dim f As String = "Έχεις ολοκληρώσει ενα σημαντικό στάδιο της ζωής σου. Αύτο είναι ευτυχία. Αλλά ξέρεις ποιός γελάει καλύτερα!! "
            TextBox2.Text = f
        End If
        If random2 = 18 And random1 <> 18 And random3 <> 18 And random4 <> 18 Then
            PictureBox5.Image = My.Resources.egkrateia
            Dim g As String = "Άκου.. Να εισαι προσεκτικός. Να υπάρχει μια εγκράτεια στις επιλογές ή αποφάσεις σου. Αλλιώς θα καταλήξεις σαν τον Ίκαρο.."
            TextBox2.Text = g
        End If
        Button3.Visible = True
        PictureBox6.Visible = True
        TextBox3.Visible = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        buttonfourclick = True
        Randomize()
        random3 = (Rnd() * 5) + 1
        If random3 = 1 And random2 <> 1 And random1 <> 1 And random4 <> 1 Then
            PictureBox7.Image = My.Resources.emperor
            Dim i As String = "θα σου συμβούλευα να μη τρέξεις σήμερα με την μηχανή σου. Παραμονεύει η αστυνομία. Εκτός και μπορείς να ξεφύγεις. Τότε γκάζωσε το!!!!!!"
            TextBox4.Text = i
        End If
        If random3 = 2 And random2 <> 2 And random1 <> 2 And random4 <> 2 Then
            PictureBox7.Image = My.Resources.hangedman
            Dim j As String = "Προβλέπεται δύσκολη εβδομάδα. Το νου σου μην σε κρεμάσουν οι φίλοι σου ή οι συγγενείς σου"
            TextBox4.Text = j
        End If
        If random3 = 3 And random2 <> 3 And random1 <> 3 And random4 <> 3 Then
            PictureBox7.Image = My.Resources.justice
            Dim k As String = "Έχεις κάποιες σοβαρές εκκρεμότητες. Τακτοποίησε τες αν θες να έρθει η δικαιοσύνη. Αλλιώς θα σε κηνυγάνε σαν τον βάζελο και εσένα.."
            TextBox4.Text = k
        End If
        If random3 = 4 And random2 <> 4 And random1 <> 4 And random4 <> 4 Then
            PictureBox7.Image = My.Resources.lover
            Dim l As String = "Ο/Η σύντροφος σου έχει καταλάβει κάτι. Μπορεί να προκύψει μια μη αναμενόμενη συνάντηση με τον/την εραστή σου. Όπως έστρωσες θα κοιμηθείς... χα χα χα"
            TextBox4.Text = l
        End If
        If random3 = 5 And random2 <> 5 And random1 <> 5 And random4 <> 5 Then
            PictureBox7.Image = My.Resources.magician
            Dim m As String = "Χμμμ μια εξυπνάδα να διαχειρίζεσαι τους στόχους σου την έχεις. Το νου σου, μην δαγκώσεις και εσυ το δηλητήριο σου"
            TextBox4.Text = m
        End If
        If random3 = 6 And random2 <> 6 And random1 <> 6 And random4 <> 6 Then
            PictureBox7.Image = My.Resources.moon
            Dim n As String = "θα ζήσεις μία κατάσταση με ανάμεικτα συναισθήματα.. Κοίτα να το απολαύσεις..."
            TextBox4.Text = n
        End If
        If random3 = 7 And random2 <> 7 And random1 <> 7 And random4 <> 7 Then
            PictureBox7.Image = My.Resources.profhths
            Dim p As String = "Δεν άκουγες τις προφητείες του Παϊσιου. Έπεξες με τις φλώγες και κάηκες"
            TextBox4.Text = p
        End If
        If random3 = 8 And random2 <> 8 And random1 <> 8 And random4 <> 8 Then
            PictureBox7.Image = My.Resources.strenght
            Dim q As String = "Καλό θα ηταν να γραφτείς στο γυμναστήριο μπας και αυξύσεις λιγο την δύναμη σου άνθρωπε του καναπέ"
            TextBox4.Text = q
        End If
        If random3 = 9 And random2 <> 9 And random1 <> 9 And random4 <> 9 Then
            PictureBox7.Image = My.Resources.wheel
            Dim r As String = "Τι θέλεις ακριβώς να σου πω? το λέει και μόνο του... Ρόδα είναι και γυρίζει. Εκτός και αν παίξεις καμία ρώσικη ρουλέτα.."
            TextBox4.Text = r
        End If
        If random3 = 10 And random2 <> 10 And random1 <> 10 And random4 <> 10 Then
            PictureBox7.Image = My.Resources.tower
            Dim s As String = "Απέτυχες παταγωδώς. Το μόνο που βλέπω για σένα είναι χάος."
            TextBox4.Text = s
        End If
        If random3 = 11 And random2 <> 11 And random1 <> 11 And random4 <> 11 Then
            PictureBox7.Image = My.Resources.fool
            Dim w As String = "Είσαι ένας χαρακτήρας που δεν κοιτάει τι θα πουν οι άλλοι, ζεις την ζωή σου με τρέλα αλλά να ξέρεις είναι πολύ σύντομη."
            TextBox4.Text = w
        End If
        If random3 = 12 And random2 <> 12 And random1 <> 12 And random4 <> 12 Then
            PictureBox7.Image = My.Resources.devil
            Dim a As String = "Μμμμ.. όχι και τόσο καλό!! Σε βασανίζει ενα απο τους μεγαλύτερους φόβους σου, και ανησυχείς για τα παραπτώματα σου. Έχεις βρει τον μπελά σου. ΚΑΛΑ ΝΑ ΠΆΘΕΙΣ!!!"
            TextBox4.Text = a
        End If
        If random3 = 13 And random2 <> 13 And random1 <> 13 And random4 <> 13 Then
            PictureBox7.Image = My.Resources.apofash
            Dim b As String = "Έχεις βρεθεί σε μια δύσκολη κατάσταση και πρέπει να πάρεις μια απόφαση. Βίασου πριν είναι αργά. Οι παράφρονες καραδοκούν"
            TextBox4.Text = b
        End If
        If random3 = 14 And random2 <> 14 And random1 <> 14 And random4 <> 14 Then
            PictureBox7.Image = My.Resources.chariot
            Dim c As String = "Είσαι ενα αποφασιστικός ανθρώπος, με δύναμη και επιβολή και σύμμαχο την επιτυχία. Τίποτα ομως δενε είναι βέβαιο. Στην θέση σου θα κάλυπτα τα νώτα μου."
            TextBox4.Text = c
        End If
        If random3 = 15 And random2 <> 15 And random1 <> 15 And random4 <> 15 Then
            PictureBox7.Image = My.Resources.death
            Dim d As String = "Σύντομα κάτι πρέπει να πεθάνει. Μην ανησυχείς δεν είναι άνθρωπος. Μάλλον τα κουρνιασμένα ονείρα που φυλάς καιρό. Κάτι καινούργιο σε περιμένει!! 'Ισως....."
            TextBox4.Text = d
        End If
        If random3 = 16 And random2 <> 16 And random1 <> 16 And random4 <> 16 Then
            PictureBox7.Image = My.Resources.sun
            Dim x As String = "Προβλέπεται αισιοδοξία, χαρά και φώς... Πριν έρθει το σκοτάδι.. "
            TextBox4.Text = x
        End If
        If random3 = 17 And random2 <> 17 And random1 <> 17 And random4 <> 17 Then
            PictureBox7.Image = My.Resources.world
            Dim f As String = "Έχεις ολοκληρώσει ενα σημαντικό στάδιο της ζωής σου. Αύτο είναι ευτυχία. Αλλά ξέρεις ποιός γελάει καλύτερα!! "
            TextBox4.Text = f
        End If
        If random3 = 18 And random2 <> 18 And random1 <> 18 And random4 <> 18 Then
            PictureBox7.Image = My.Resources.egkrateia
            Dim g As String = "Άκου.. Να εισαι προσεκτικός. Να υπάρχει μια εγκράτεια στις επιλογές ή αποφάσεις σου. Αλλιώς θα καταλήξεις σαν τον Ίκαρο.."
            TextBox4.Text = g
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Label2.Text = "Ανακάλυψε τη μοίρα που σου επιφυλάσσει το μέλλον..."
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Ευχαριστούμε που μας εμπιστευτήκατε..")
        Application.Exit()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)
        MessageBox.Show("Ευχαριστούμε που μας εμπιστευτήκατε!!")
        Application.Exit()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Play("E:\vb.net\tarot\tarotmusic.wav", AudioPlayMode.Background)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        PictureBox3.Visible = False
        Button10.Visible = False
    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ilikia As Integer = (TextBox7.Text)
        If TextBox7.Text = (Text.Empty) Then
            MessageBox.Show("Παρακαλώ βάλε την ηλικία σου.")
        End If
        If TextBox7.Text <> "" Then
            If ilikia >= 18 Then
                MessageBox.Show("Μπορείτε να ανακαλύψετε την μοίρα σας!!!")
                Panel1.Visible = False
            Else
                MessageBox.Show("Δεν επιτρέπεται για την ηλικία σου!!!")
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Button8_Click_2(sender As Object, e As EventArgs) Handles Button8.Click
        My.Computer.Audio.Play("E:\vb.net\tarot\tarotmusic.wav", AudioPlayMode.Background)
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button7_Click_2(sender As Object, e As EventArgs) Handles Button7.Click
        MessageBox.Show("Αν θέλετε 24ωρη ζωντανή εξυπηρέτηση καλέστε στο 210-5542755 και η πιο έγκυρη ομάδα ταρώ θα σας εξυπηρετήσει!")
        MessageBox.Show("Ευχαριστούμε που μας εμπιστευτήκατε!!")

        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Ευχαριστούμε που μας εμπιστευτήκατε!!")
        Application.Exit()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Play("E:\vb.net\tarot\tarotmusic.wav", AudioPlayMode.Background)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Stop()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        My.Computer.Audio.Play("E:\vb.net\tarot\tarotmusic.wav", AudioPlayMode.Background)
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        MessageBox.Show("Ευχαριστούμε που μας εμπιστευτήκατε!!")
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        buttonthreeclick = True
        Randomize()
        random4 = (Rnd() * 5) + 1
        If random4 = 1 And random3 <> 1 And random2 <> 1 And random1 <> 1 Then
            PictureBox6.Image = My.Resources.devil
            Dim a As String = "Μμμμ.. όχι και τόσο καλό!! Σε βασανίζει ενα απο τους μεγαλύτερους φόβους σου, και ανησυχείς για τα παραπτώματα σου. Έχεις βρει τον μπελά σου. ΚΑΛΑ ΝΑ ΠΆΘΕΙΣ!!!"
            TextBox3.Text = a
        End If
        If random4 = 2 And random3 <> 2 And random2 <> 2 And random1 <> 2 Then
            PictureBox6.Image = My.Resources.apofash
            Dim b As String = "Έχεις βρεθεί σε μια δύσκολη κατάσταση και πρέπει να πάρεις μια απόφαση. Βίασου πριν είναι αργά. Οι παράφρονες καραδοκούν"
            TextBox3.Text = b
        End If
        If random4 = 3 And random3 <> 3 And random2 <> 3 And random1 <> 3 Then
            PictureBox6.Image = My.Resources.chariot
            Dim c As String = "Είσαι ενα αποφασιστικός ανθρώπος, με δύναμη και επιβολή και σύμμαχο την επιτυχία. Τίποτα ομως δενε είναι βέβαιο. Στην θέση σου θα κάλυπτα τα νώτα μου."
            TextBox3.Text = c
        End If
        If random4 = 4 And random3 <> 4 And random2 <> 4 And random1 <> 4 Then
            PictureBox6.Image = My.Resources.death
            Dim d As String = "Σύντομα κάτι πρέπει να πεθάνει. Μην ανησυχείς δεν είναι άνθρωπος. Μάλλον τα κουρνιασμένα ονείρα που φυλάς καιρό. Κάτι καινούργιο σε περιμένει!! 'Ισως....."
            TextBox3.Text = d
        End If
        If random4 = 5 And random3 <> 5 And random2 <> 5 And random1 <> 5 Then
            PictureBox6.Image = My.Resources.sun
            Dim x As String = "Προβλέπεται αισιοδοξία, χαρά και φώς... Πριν έρθει το σκοτάδι.. "
            TextBox3.Text = x
        End If
        If random4 = 6 And random3 <> 6 And random2 <> 6 And random1 <> 6 Then
            PictureBox6.Image = My.Resources.world
            Dim f As String = "Έχεις ολοκληρώσει ενα σημαντικό στάδιο της ζωής σου. Αύτο είναι ευτυχία. Αλλά ξέρεις ποιός γελάει καλύτερα!! "
            TextBox3.Text = f
        End If
        If random4 = 7 And random3 <> 7 And random2 <> 7 And random1 <> 7 Then
            PictureBox6.Image = My.Resources.egkrateia
            Dim g As String = "Άκου.. Να εισαι προσεκτικός. Να υπάρχει μια εγκράτεια στις επιλογές ή αποφάσεις σου. Αλλιώς θα καταλήξεις σαν τον Ίκαρο.."
            TextBox3.Text = g
        End If
        If random4 = 8 And random3 <> 8 And random2 <> 8 And random1 <> 8 Then
            PictureBox6.Image = My.Resources.emperor
            Dim i As String = "θα σου συμβούλευα να μη τρέξεις σήμερα με την μηχανή σου. Παραμονεύει η αστυνομία. Εκτός και μπορείς να ξεφύγεις. Τότε γκάζωσε το!!!!!!"
            TextBox3.Text = i
        End If
        If random4 = 9 And random3 <> 9 And random2 <> 9 And random1 <> 9 Then
            PictureBox6.Image = My.Resources.hangedman
            Dim j As String = "Προβλέπεται δύσκολη εβδομάδα. Το νου σου μην σε κρεμάσουν οι φίλοι σου ή οι συγγενείς σου"
            TextBox3.Text = j
        End If
        If random4 = 10 And random3 <> 10 And random2 <> 10 And random1 <> 10 Then
            PictureBox6.Image = My.Resources.justice
            Dim k As String = "Έχεις κάποιες σοβαρές εκκρεμότητες. Τακτοποίησε τες αν θες να έρθει η δικαιοσύνη. Αλλιώς θα σε κηνυγάνε σαν τον βάζελο και εσένα.."
            TextBox3.Text = k
        End If
        If random4 = 11 And random3 <> 11 And random2 <> 11 And random1 <> 11 Then
            PictureBox6.Image = My.Resources.lover
            Dim l As String = "Ο/Η σύντροφος σου έχει καταλάβει κάτι. Μπορεί να προκύψει μια μη αναμενόμενη συνάντηση με τον/την εραστή σου. Όπως έστρωσες θα κοιμηθείς... χα χα χα"
            TextBox3.Text = l
        End If
        If random4 = 12 And random3 <> 12 And random2 <> 12 And random1 <> 12 Then
            PictureBox6.Image = My.Resources.magician
            Dim m As String = "Χμμμ μια εξυπνάδα να διαχειρίζεσαι τους στόχους σου την έχεις. Το νου σου, μην δαγκώσεις και εσυ το δηλητήριο σου"
            TextBox3.Text = m
        End If
        If random4 = 13 And random3 <> 13 And random2 <> 13 And random1 <> 13 Then
            PictureBox6.Image = My.Resources.moon
            Dim n As String = "θα ζήσεις μία κατάσταση με ανάμεικτα συναισθήματα.. Κοίτα να το απολαύσεις..."
            TextBox3.Text = n
        End If
        If random4 = 14 And random3 <> 14 And random2 <> 14 And random1 <> 14 Then
            PictureBox6.Image = My.Resources.profhths
            Dim p As String = "Δεν άκουγες τις προφητείες του Παϊσιου. Έπεξες με τις φλώγες και κάηκες"
            TextBox3.Text = p
        End If
        If random4 = 15 And random3 <> 15 And random2 <> 15 And random1 <> 15 Then
            PictureBox6.Image = My.Resources.strenght
            Dim q As String = "Καλό θα ηταν να γραφτείς στο γυμναστήριο μπας και αυξύσεις λιγο την δύναμη σου άνθρωπε του καναπέ"
            TextBox3.Text = q
        End If
        If random4 = 16 And random3 <> 16 And random2 <> 16 And random1 <> 16 Then
            PictureBox6.Image = My.Resources.wheel
            Dim r As String = "Τι θέλεις ακριβώς να σου πω? το λέει και μόνο του... Ρόδα είναι και γυρίζει. Εκτός και αν παίξεις καμία ρώσικη ρουλέτα.."
            TextBox3.Text = r
        End If
        If random4 = 17 And random3 <> 17 And random2 <> 17 And random1 <> 17 Then
            PictureBox6.Image = My.Resources.tower
            Dim s As String = "Απέτυχες παταγωδώς. Το μόνο που βλέπω για σένα είναι χάος."
            TextBox3.Text = s
        End If
        If random4 = 18 And random3 <> 18 And random2 <> 18 And random1 <> 18 Then
            PictureBox6.Image = My.Resources.fool
            Dim w As String = "Είσαι ένας χαρακτήρας που δεν κοιτάει τι θα πουν οι άλλοι, ζεις την ζωή σου με τρέλα αλλά να ξέρεις είναι πολύ σύντομη."
            TextBox3.Text = w
        End If

        Button4.Visible = True
        PictureBox7.Visible = True
        TextBox4.Visible = True


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.tarotmusic, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim apanthseis() = {"Δεν εχω και πολλά λόγια να σου πω. σε γενικές γραμμές η ζωή σου ειναι ισοροπημένη και άλλες πάλι ειναι σαν να ποδοπατήθηκε απο ταύρους.",
           "Ζήσε με περισσότερη τρέλα και αν πάθεις κατι, το έπαθες!! Τουλάχιστον θα έχεις ζήσει κάτι.",
"Τα ταρώ θα είναι εδώ να σου δείχνουν το δρόμο για την ευτυχία",
"Η ζωή σου σε γενικές γραμμές είναι ισσοροπημένη, έχεις καλούς φίλους και βαδίζεις σε μονοπάτια που ξέρεις. Αλλά αυτό δεν σημαίνει ότι δεν θα την πατήσεις, πρόσεχε τον κλειστό σου κύκλο και ιδιαίτερα σε ποιον ανοίγεσαι!!",
"Δεν θα έλεγα οτι είναι καλή περίοδος για να ανοιχτείς, τα οικονομικά σου δεν ειναι και στα καλύτερα τους, ουτε περίοδος για καινούργιους φίλους. Αφοσιώσου σε σένα και στην δουλειά σου πιο πολύ και όσο για τα άλλα έχεις καιρό.",
"Θα συναντήσεις άτομα απο παλιά. Πρόσεχε πως θα αντιμετωπίσεις αυτές τις εκπλήξεις γιατί μπορεί να σου φέρουν πόνο και δυστυχία.",
"Καιρός να ανοιχτείς λίγο και να πραγματοποιήσεις τα ονειρά σου χωρίς υπερβολές πάντα. Είναι η κατάλληλη περίοδος να ανοίξεις το μαγαζί που πάντα ήθελες ή το ταξίδι που ονειρευόσουν τόσο καιρό. Πάρε τις σωστές αποφάσεις που θα σε οδηγήσουν στην ευτυχία",
"Έχω άσχημα νέα για σένα, πρόσεχε που πατάς και με ποιους συναστρέφεσαι. Οι εχθροί παραμονεύουν για το πρώτο σου στραβοπάτημα. Κάθισε περισσότερο στο σπίτι σου και απόφευγε τις εξόδους μέχρι να περάσει αυτή η καταιγίδα ",
"Ένα ταξίδι θα χρειαστείς να κάνεις για σοβαρό λόγο. Αυτή την περίοδο απόφυγε το στρες και το άγχος και πρόσεχε την υγεία σου. Είναι ενας δύσκολος μήνας που θα σου βάζει συνέχεια εμπόδια. ΠΡΟΕΤΟΙΜΑΣΟΥ!!!"}
        Dim r As New Random
        Dim apantisi As Integer = r.Next(1, 7)
        Dim sex As String
        'If ButtonOneClick And buttontwoclick And buttonthreeclick And buttonfourclick Then
        '    TextBox6.Visible = True
        'Else MessageBox.Show("Πρέπει να εμφανίσεις όλες τις κάρτες")
        'End If
        If PictureBox5.Visible = True And PictureBox6.Visible = True And PictureBox7.Visible = True Then
            TextBox6.Visible = True
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
        Else : MessageBox.Show("Πρέπει να εμφανίσεις όλες τις κάρτες")
        End If
        If TextBox5.Text <> "" Then
            Dim lastname As String = (TextBox5.Text)
            lastname = lastname.Substring(lastname.Length - 1)
            If (lastname > "ω") Or (lastname < "α") Then
                TextBox6.Visible = False
                MessageBox.Show("Ελληνικοί χαρακτήρες μόνο!!!")
            End If
            If lastname = "ς" Then
                sex = "ΑΝΤΡΑΣ"
            Else
                sex = "ΓΥΝΑΙΚΑ"

            End If
            Dim όνομα_στην_κλητική As String = TextBox5.Text.Remove(TextBox5.Text.Length - 1)
            If sex = "ΑΝΤΡΑΣ" Then
                Dim MyStringBuilder As New System.Text.StringBuilder(όνομα_στην_κλητική & " ")
                MyStringBuilder.Append(apanthseis(apantisi))
                TextBox6.Text = MyStringBuilder.ToString
            End If
            If sex = "ΓΥΝΑΙΚΑ" Then
                Dim MyStringBuilder As New System.Text.StringBuilder(TextBox5.Text & " ")
                MyStringBuilder.Append(apanthseis(apantisi))
                TextBox6.Text = MyStringBuilder.ToString
            End If
        Else : MessageBox.Show("Πως γίνεται να μην έχεις όνομα?? Είσαι απο άλλον πλανήτη?")
        End If
    End Sub
End Class
